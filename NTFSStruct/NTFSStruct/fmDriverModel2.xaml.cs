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
    /// Логика взаимодействия для fmDriverModel2.xaml
    /// </summary>
    public partial class fmDriverModel2 : Window
    {
        public fmDriverModel2()
        {
            InitializeComponent();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\DriverModel2.txt");
            Helper.LoadImage(@"image\driver\second\1.png",imDriverModel);
            Helper.LoadImage(@"image\void.png", imProtocol);
            Helper.LoadImage(@"image\void.png", imServiceJournal);
            Helper.LoadImage(@"image\void.png", imResetJournal);
            Helper.LoadImage(@"image\void.png", imManagerCache);
            Helper.LoadImage(@"image\void.png", imWriteCache);
            Helper.LoadImage(@"image\void.png", imManagerVirtualMem);
            Helper.LoadImage(@"image\void.png", imResetCache);
            Helper.LoadImage(@"image\void.png", imLoadData);
            Helper.LoadImage(@"image\void.png", imLoadFromDisk);
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\2.png", imDriverModel);
           
        }

        private void imProtocol_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imServiceJournal_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\3.png", imDriverModel);
        }

        private void imServiceJournal_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imResetJournal_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\4.png", imDriverModel);
        }

        private void imResetJournal_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imManagerCache_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\5.png", imDriverModel);
        }

        private void imManagerCache_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imWriteCache_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\6.png", imDriverModel);
        }

        private void imWriteCache_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imManagerVirtualMem_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\7.png", imDriverModel);
        }

        private void imManagerVirtualMem_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imResetCache_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\8.png", imDriverModel);
        }

        private void imResetCache_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imLoadData_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\9.png", imDriverModel);
        }

        private void imLoadData_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void imLoadFromDisk_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\10.png", imDriverModel);
        }

        private void imLoadFromDisk_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\second\1.png", imDriverModel);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fmModelNTFS form = new fmModelNTFS();
            form.Show();
        }

    }
}
