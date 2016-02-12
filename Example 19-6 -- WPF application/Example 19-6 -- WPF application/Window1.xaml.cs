using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example_19_6____WPF_application
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void PresPhotoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                if (lb.SelectedItem != null)
                {
                    string chosenName = (lb.SelectedItem as ImageURL).Name.ToString();
                    Title = chosenName;
                }
            }
            else
            {
                throw new ArgumentException("Expected ListBox to call selection changed in PresPhotoListBox_SelectionChanged");
            }
        }

    }
}
