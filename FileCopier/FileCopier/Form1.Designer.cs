namespace FileCopier
{
    partial class FrmFileCopier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.tvwSource = new System.Windows.Forms.TreeView();
            this.tvwTargetDir = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(95, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source Files";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(217, 13);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(92, 16);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target Files";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(220, 32);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.Size = new System.Drawing.Size(202, 20);
            this.txtTargetDir.TabIndex = 2;
            // 
            // tvwSource
            // 
            this.tvwSource.CheckBoxes = true;
            this.tvwSource.Location = new System.Drawing.Point(16, 32);
            this.tvwSource.Name = "tvwSource";
            this.tvwSource.Size = new System.Drawing.Size(189, 267);
            this.tvwSource.TabIndex = 3;
            this.tvwSource.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwSource_AfterCheck);
            this.tvwSource.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwSource_BeforeExpand);
            // 
            // tvwTargetDir
            // 
            this.tvwTargetDir.Location = new System.Drawing.Point(220, 58);
            this.tvwTargetDir.Name = "tvwTargetDir";
            this.tvwTargetDir.Size = new System.Drawing.Size(202, 241);
            this.tvwTargetDir.TabIndex = 4;
            this.tvwTargetDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwTargetDir_BeforeExpand);
            this.tvwTargetDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwTargetDir_AfterSelect);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(70, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(220, 311);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(108, 17);
            this.chkOverwrite.TabIndex = 7;
            this.chkOverwrite.Text = "Overwrite if exists";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(349, 305);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(349, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 396);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tvwTargetDir);
            this.Controls.Add(this.tvwSource);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "FrmFileCopier";
            this.Text = "File  Copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtTargetDir;
        private System.Windows.Forms.TreeView tvwSource;
        private System.Windows.Forms.TreeView tvwTargetDir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}

