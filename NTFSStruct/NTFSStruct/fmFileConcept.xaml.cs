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
    /// Логика взаимодействия для fmFileConcept.xaml
    /// </summary>
    public partial class fmFileConcept : Window
    {
        public fmFileConcept()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\NTFS_Struct\3.txt");
            tbText2.Text = File.ReadAllText(@"txt\NTFS_Struct\4.txt");
            Helper.LoadImage(@"image\DiscConf\6.png",imFileRef);
            Helper.LoadImage(@"image\DiscConf\9.png", imMftRecord);
            Helper.LoadImage(@"image\void.png", im);
            Helper.LoadImage(@"image\void.png", im2);
            Helper.LoadImage(@"image\void.png", imMTFSelect1);
            Helper.LoadImage(@"image\void.png", imMtfSelect2);
            Helper.LoadImage(@"image\void.png", imMTFSelect3);
            Helper.LoadImage(@"image\void.png", imMTFSSelect4);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fmConception form = new fmConception();
            form.Show();
        }

        private void im_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\7.png", imFileRef);
        }

        private void im_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\6.png", imFileRef);
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\8.png", imFileRef);
        }

        private void im2_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\6.png", imFileRef);
        }

        private void imMTFSelect1_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\10.png", imMftRecord);
        }

        private void imMTFSelect1_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\9.png", imMftRecord);
        }

        private void imMtfSelect2_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\11.png", imMftRecord);
        }

        private void imMtfSelect2_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\9.png", imMftRecord);
        }

        private void imMTFSelect3_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\12.png", imMftRecord);
        }

        private void imMTFSelect3_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\9.png", imMftRecord);
        }

        private void imMTFSSelect3_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\13.png", imMftRecord);
        }

        private void imMTFSSelect3_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\9.png", imMftRecord);
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
