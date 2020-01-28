//Adam Ackerman
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

namespace WPF_Examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            txtfname.Text = "";
            txtlname.Text = string.Empty;
            txtbdate.Text = string.Empty;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            listLetters.Items.Clear();

            string firstname, lastname, birthDate;
            firstname = txtfname.Text;
            lastname = txtlname.Text;
            birthDate = txtbdate.Text;


            string fullName = firstname + " " + lastname;
            DateTime dob = Convert.ToDateTime(birthDate);

            foreach (var letter in fullName)
            {
                listLetters.Items.Add(letter);

            }

            listLetters.Items.Add($"You were born on a {dob.DayOfWeek}.");

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you for using our application! =)");
            Close();

        }
    }
}
