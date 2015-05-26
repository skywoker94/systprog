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
using System.Windows.Shapes;

namespace NTFSStruct
{
    /// <summary>
    /// Логика взаимодействия для fmStructNTFS.xaml
    /// </summary>
    public partial class fmStructNTFS : Window
    {
        private bool open = false;
        public fmStructNTFS()
        {
            InitializeComponent();
        }

        private void lbConception_MouseEnter(object sender, MouseEventArgs e)
        {
            lbConception.Foreground = Brushes.Coral;
        }

        private void lbConception_MouseLeave(object sender, MouseEventArgs e)
        {
            lbConception.Foreground = Brushes.Black;
        }

        private void lbConception_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmConception form = new fmConception();
            form.Show();
            open = true;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                MainWindow form = new MainWindow();
                form.Show();
            }
        }

        private void lbStruct_MouseEnter(object sender, MouseEventArgs e)
        {
            lbStruct.Foreground = Brushes.Coral;
        }

        private void lbStruct_MouseLeave(object sender, MouseEventArgs e)
        {
            lbStruct.Foreground = Brushes.Black;
        }

        private void lbStruct_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmDiskStruct form = new fmDiskStruct();
            form.Show();
            open = true;
            Close();
        }

        private void lbCatalogStruct_MouseEnter(object sender, MouseEventArgs e)
        {
            lbCatalogStruct.Foreground = Brushes.Coral;
        }

        private void lbCatalogStruct_MouseLeave(object sender, MouseEventArgs e)
        {
            lbCatalogStruct.Foreground = Brushes.Black;
        }

        private void lbCatalogStruct_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmStructCatalog form = new fmStructCatalog();
            form.Show();
            open = true;
            Close();
        }
    }
}
