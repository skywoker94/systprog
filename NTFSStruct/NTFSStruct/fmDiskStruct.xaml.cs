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
    /// Логика взаимодействия для fmDiskStruct.xaml
    /// </summary>
    public partial class fmDiskStruct : Window
    {
        public fmDiskStruct()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\NTFS_Struct2\1.txt");
            Helper.LoadImage(@"image\DiskStruct\1.png",imResAtr);
        }

        private void imResAtr_MouseEnter(object sender, MouseEventArgs e)
        {

            Helper.LoadImage(@"image\void.png", imResAtr2);
            Helper.LoadImage(@"image\DiskStruct\1.png", imResAtr);
           
        }

        private void imResAtr_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void imResAtr2_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiskStruct\2.png", imResAtr2);
            Helper.LoadImage(@"image\void.png", imResAtr);
        }

        private void imResAtr2_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\void.png", imResAtr2);
            Helper.LoadImage(@"image\DiskStruct\1.png", imResAtr);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fmStructNTFS form = new fmStructNTFS();
            form.Show();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            lbBack.Foreground=Brushes.Coral;
        }

        private void lbBack_MouseLeave(object sender, MouseEventArgs e)
        {
            lbBack.Foreground=Brushes.Black;
        }

        private void lbBack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
