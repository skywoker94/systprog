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
    /// Логика взаимодействия для fmDriverModel.xaml
    /// </summary>
    public partial class fmDriverModel : Window
    {
        private bool open = false;
        public fmDriverModel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\DriverModel.txt");
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
            Helper.LoadImage(@"image\void.png",imClick);
        }

        private void imDriverModel_MouseEnter(object sender, MouseEventArgs e)
        {
           
            Helper.LoadImage(@"image\driver\first\2.png", imDriverModel);

        }

        private void imDriverModel_MouseLeave(object sender, MouseEventArgs e)
        {
           
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imDriverModel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmDriverModel2 form = new fmDriverModel2();
            form.Show();
            open = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                fmModelNTFS form = new fmModelNTFS();
                form.Show();
            }
        }
    }
}
