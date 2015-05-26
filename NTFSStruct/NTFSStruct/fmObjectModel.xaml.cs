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
    /// Логика взаимодействия для fmObjectModel.xaml
    /// </summary>
    public partial class fmObjectModel : Window
    {
        public fmObjectModel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\ObjectModel.txt");
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
            Helper.LoadImage(@"image\void.png", imManneger);
            Helper.LoadImage(@"image\void.png", imNTFS);
            Helper.LoadImage(@"image\void.png", imConrolBlock);
            Helper.LoadImage(@"image\void.png", imDataBase);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fmModelNTFS form = new fmModelNTFS();
            form.Show();
        }

        private void imManneger_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void imManneger_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imManneger_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\2.png", imScheme);
        }

        private void imNTFS_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\3.png", imScheme);
        }

        private void imNTFS_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imConrolBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void imConrolBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\4.png", imScheme);
        }

        private void imConrolBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imDataBase_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\5.png", imScheme);
        }

        private void imDataBase_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }


      
    }
}
