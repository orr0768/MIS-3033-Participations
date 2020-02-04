using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_FileProcessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btngetpride_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();

            var bookContents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");

            r.Text = bookContents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.BurlyWood;



            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;

        }

        private void btngetSales_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\orr0768\Downloads\SalesJan2009.csv";

            var contents = File.ReadAllLines(path);

            double sumOfPrices = 0;

            for (int i = 1; i < contents.Length; i++)
            {
                string row = contents[i];

                var pieces = row.Split(',');

                sumOfPrices += Convert.ToDouble(pieces[2]);

                    
                lstSales.Items.Add(pieces[1] + " - " + pieces[2]);
            }

            

            //foreach (var row in contents)
            //{
            //    lstSales.Items.Add(row);
            //}

            //lstSales.Items.Add(contents);



        }
    }
}
