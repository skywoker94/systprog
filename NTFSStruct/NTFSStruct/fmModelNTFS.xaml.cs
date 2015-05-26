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
using System.Windows.Shapes;

namespace NTFSStruct
{
    /// <summary>
    /// Логика взаимодействия для fmModelNTFS.xaml
    /// </summary>
    public partial class fmModelNTFS : Window
    {
        private bool open = false;
        public fmModelNTFS()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\Models.txt");

        }

        private void lbDriverModel_MouseEnter(object sender, MouseEventArgs e)
        {
            lbDriverModel.Foreground = Brushes.Coral;
        }

        private void lbDriverModel_MouseLeave(object sender, MouseEventArgs e)
        {
            lbDriverModel.Foreground = Brushes.Black;
        }

        private void lbDataBaseModel_MouseEnter(object sender, MouseEventArgs e)
        {
            lbDataBaseModel.Foreground = Brushes.Coral;
        }

        private void lbDataBaseModel_MouseLeave(object sender, MouseEventArgs e)
        {
            lbDataBaseModel.Foreground = Brushes.Black;
        }

        private void lbOOPModel_MouseEnter(object sender, MouseEventArgs e)
        {
            lbOOPModel.Foreground = Brushes.Coral;
        }

        private void lbOOPModel_MouseLeave(object sender, MouseEventArgs e)
        {
            lbOOPModel.Foreground = Brushes.Black;
        }

        private void lbDriverModel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmDriverModel form = new fmDriverModel();
            form.Show();
            open = true;
            this.Close();

        }

        private void lbDataBaseModel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmModelDB form = new fmModelDB();
            form.Show();
            open = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                MainWindow form = new MainWindow();
                form.Show();
            }
        }

        private void lbOOPModel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmObjectModel form = new fmObjectModel();
            form.Show();
            open = true;
            this.Close();
        }
    }
}
