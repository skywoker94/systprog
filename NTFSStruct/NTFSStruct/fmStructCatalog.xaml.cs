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
    /// Логика взаимодействия для fmStructCatalog.xaml
    /// </summary>
    public partial class fmStructCatalog : Window
    {
        public fmStructCatalog()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\1.png", imSmallCatalog);
            Helper.LoadImage(@"image\CatalogStruct\3.png", imBigCatalog);
            Helper.LoadImage(@"image\CatalogStruct\6.png", imVirt);
            Helper.LoadImage(@"image\void.png", imIndexBuf);
            
        }

        private void imSmallCatalog_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\2.png", imSmallCatalog);
        }

        private void imSmallCatalog_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\1.png", imSmallCatalog);
        }

        private void imBigCatalog_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\4.png", imBigCatalog);
        }

        private void imBigCatalog_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\3.png", imBigCatalog);
        }

        private void imIndexBuf_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\5.png", imBigCatalog);
        }

        private void imIndexBuf_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\3.png", imBigCatalog);
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\7.png", imVirt);
        }

        private void imVirt_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\CatalogStruct\6.png", imVirt);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            fmStructNTFS form = new fmStructNTFS();
            form.Show();
        }
    }
}
