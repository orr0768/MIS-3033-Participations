using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Classes_Part
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtName.Text = "";
            txtAddress.Text = string.Empty;
            txtZip.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            
            


            EntryForm form1 = new EntryForm();
            form1.Name = txtName.Text;
            form1.Address = txtAddress.Text;
            form1.ZipCode = Convert.ToInt32(txtZip.Text);

            

            lstKeepTrack.Items.Add(form1.ToString());

            
         

            

           

        }
    }
}
