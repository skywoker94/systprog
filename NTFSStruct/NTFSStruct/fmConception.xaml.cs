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
    /// Логика взаимодействия для fmConception.xaml
    /// </summary>
    public partial class fmConception : Window
    {
        public fmConception()
        {
            InitializeComponent();
        }

        private bool open;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\NTFS_Struct\1.txt");
            tbText2.Text = File.ReadAllText(@"txt\NTFS_Struct\2.txt");
            Helper.LoadImage(@"image\DiscConf\1.png",imDiscConf);
            Helper.LoadImage(@"image\DiscConf\3.png", imDisc);
            Helper.LoadImage(@"image\void.png", imDisc2);
            Helper.LoadImage(@"image\void.png", imCluster);

        }

        private void imDiscConf_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void imDiscConf_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\2.png", imDiscConf);
        }

        private void imDiscConf_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\1.png", imDiscConf);
        }

        private void imDisc2_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\4.png", imDisc);
        }

        private void imDisc2_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\3.png", imDisc);
        }

        private void imCluster_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\5.png", imDisc);
        }

        private void imCluster_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\DiscConf\3.png", imDisc);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                fmStructNTFS form = new fmStructNTFS();
                form.Show();
            }
        }

        private void lbNext_MouseEnter(object sender, MouseEventArgs e)
        {
            lbNext.Foreground = Brushes.Coral;
        }

        private void lbNext_MouseLeave(object sender, MouseEventArgs e)
        {
            lbNext.Foreground = Brushes.Black;
        }

        private void lbNext_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmFileConcept form = new fmFileConcept();
            form.Show();
            open = true;
            Close();
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
