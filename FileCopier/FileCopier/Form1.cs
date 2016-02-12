using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileCopier
{
    public partial class FrmFileCopier : Form
    {
        private const int MaxLevel = 2;

        public FrmFileCopier()
        {
            InitializeComponent();
            FillDirectoryTree(tvwSource, true);
            FillDirectoryTree(tvwTargetDir, false);
        }

        // the nested FileComparer class implements
        // IComparer, and allows you to compare two
        // FileInfo objects by file size. Note that 
        // you're comparing large to small, so the 
        // expected results are reversed.
        public class FileComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo file1, FileInfo file2)
            {
                if (file1.Length > file2.Length)
                {
                    return -1;
                }
                if (file1.Length < file2.Length)
                {
                    return 1;
                }
                return 0;
            }
        }

        // method for both TreeView controls that fills the TreeViews
        // with the contents of the local drives.
        private void FillDirectoryTree(TreeView tvw, bool isSource)
        {
            // clear the tree first
            tvw.Nodes.Clear();

            // find the root drives for root nodes
            string[] strDrives = Environment.GetLogicalDrives();

            // Iterate through the drives, adding them to the tree
            foreach (string rootDirectoryName in strDrives)
            {
                try
                {
                    // If a drive is not ready, it will be skipped
                    DirectoryInfo dir = new DirectoryInfo(rootDirectoryName);
                    dir.GetDirectories();  // forces an exception if the drive isn't ready

                    // create a new TreeNode object
                    TreeNode ndRoot = new TreeNode(rootDirectoryName);
                    
                    // add the TreeNode to the TreeView's collection for each root directory
                    tvw.Nodes.Add(ndRoot);

                    //  Add subdirectory nodes.
                    //  If the Treeview is the source,
                    //  then also get the filenames.
                    if (isSource)
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, true, 1);
                    }
                    else
                    {
                        GetSubDirectoryNodes(ndRoot, ndRoot.Text, false, 1);
                    }
                }
                // The catch block does nothing in this example, but you
                // could add custom exception code here.
                catch
                {
                }
                Application.DoEvents();
            }
        }

        // Gets all the subdirectories below the directory node.
        // that was passed in, and adds them to the directory tree.
        // The parameters passed in are the parent node
        // for this subdirectory,
        // the full path name of this subdirectory,
        // and a Boolean to indicate
        // whether or not to get the files in the subdirectory.
        private void GetSubDirectoryNodes(TreeNode parentNode, string fullName, bool getFileNames, int level)
        {
            DirectoryInfo dir = new DirectoryInfo(fullName);
            DirectoryInfo[] dirSubs = dir.GetDirectories();

            // add a child node for each subdirectory
            foreach (DirectoryInfo dirSub in dirSubs)
            {
                // Skip hidden folders
                if ((dirSub.Attributes & FileAttributes.Hidden) != 0)
                {
                    continue;
                }

                // Create a new node and add it to the tree
                TreeNode subNode = new TreeNode(dirSub.Name);
                parentNode.Nodes.Add(subNode);
                
                // If this is the first level of recursion,
                // call the method again recursively.
                if (level < MaxLevel)
                {
                    GetSubDirectoryNodes(subNode, dirSub.FullName, getFileNames, level + 1);
                }
            }

            if (getFileNames)
            {
                // Get any files for this node.
                FileInfo[] files = dir.GetFiles();

                // Create a node for each file, if any
                foreach (FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    parentNode.Nodes.Add(fileNode);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tvwSource_AfterCheck(object sender, TreeViewEventArgs e)
        {
            SetCheck(e.Node, e.Node.Checked);
        }

        // Recursively checks all subdirectories
        // when the parent directory is checked
        private void SetCheck(TreeNode node, bool check)
        {
            foreach (TreeNode n in node.Nodes)
            {
                n.Checked = check;   // check the node
                if (n.Nodes.Count != 0)
                {
                    SetCheck(n, check);
                }
            }
        }

        private void tvwSource_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            tvwExpand(sender, e.Node);
        }
        private void tvwTargetDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            tvwExpand(sender, e.Node);
        }

        // recursively gets the subdirectories
        // when a directory is expanded
        private void tvwExpand(object sender, TreeNode currentNode)
        {
            TreeView tvw = (TreeView)sender;
            bool getFiles = (tvw == tvwSource);
            string fullName = currentNode.FullPath;
            currentNode.Nodes.Clear();
            GetSubDirectoryNodes(currentNode, fullName, getFiles, 1);
        }

        private void tvwTargetDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // get the full path for the selected directory
            string theFullPath = e.Node.FullPath;

            // if it is not a leaf, it will end with a back slash
            // remove the backslash
            if (theFullPath.EndsWith("\\"))
            {
                theFullPath = theFullPath.Substring(0, theFullPath.Length - 1);
            }
            // insert the path in the text box
            txtTargetDir.Text = theFullPath;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears all the checked directories
            // in the source TreeView
            foreach (TreeNode node in tvwSource.Nodes)
            {
                SetCheck(node, false);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // get the sorted list of files
            List<FileInfo> fileList = GetFileList();

            // copy the files
            foreach (FileInfo file in fileList)
            {
                try
                {
                    lblStatus.Text = "Copying " + txtTargetDir.Text + "\\" + file.Name + "...";
                    Application.DoEvents();
                    // copy the file to its destination location
                    file.CopyTo(txtTargetDir.Text + "\\" + file.Name, chkOverwrite.Checked);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            lblStatus.Text = "Done.";

        }

        private List<FileInfo> GetFileList()
        {
            // create an unsorted array list of the full file names
            List<string> fileNames = new List<string>();
            foreach (TreeNode theNode in tvwSource.Nodes)
            {
                GetCheckedFiles(theNode, fileNames);
            }

            // Create a list to hold the FileInfo objects
            List<FileInfo> fileList = new List<FileInfo>();

            // for each of the file names in the unsorted list
            // if the name corresponds to a file (and not a directory),
            // add it to the file list
            foreach (string fileName in fileNames)
            {
                // create a file with the name
                FileInfo file = new FileInfo(fileName);
                // see if the file exists on the disk
                // this fails if it is a directory
                if (file.Exists)
                {
                    fileList.Add(file);
                }
            }

            // Create an instance of the IComparer interface
            IComparer<FileInfo> comparer = (IComparer<FileInfo>)new FileComparer();

            // pass the comparer to the sort method so that the list
            // is sorted by the compare method of comparer.
            fileList.Sort(comparer);
            return fileList;
        }

        private void GetCheckedFiles(TreeNode node, List<string> fileNames)
        {
            // if this is a leaf...
            if (node.Nodes.Count == 0)
            {
                // if the node was checked...
                if (node.Checked)
                {
                    // add the full path to the arrayList
                    fileNames.Add(node.FullPath);
                }
            }
            else
            {
                foreach (TreeNode n in node.Nodes)
                {
                    GetCheckedFiles(n, fileNames);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ask them if they are sure
            System.Windows.Forms.DialogResult result = MessageBox.Show(
               "Are you quite sure?",              // msg
               "Delete Files",                     // caption
               MessageBoxButtons.OKCancel,         // buttons
               MessageBoxIcon.Exclamation,         // icons
               MessageBoxDefaultButton.Button2);   // default button
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                List<FileInfo> fileNames = GetFileList();
                foreach (FileInfo file in fileNames)
                {
                    try
                    {
                        // update the label to show progress
                        lblStatus.Text = "Deleting " + txtTargetDir.Text + "\\" + file.Name + "...";
                        Application.DoEvents();
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        // you may want to do more than
                        // just show the message
                        MessageBox.Show(ex.Message);
                    }
                }
                lblStatus.Text = "Done.";
                Application.DoEvents();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
