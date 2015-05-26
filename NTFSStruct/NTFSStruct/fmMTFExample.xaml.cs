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
    /// Логика взаимодействия для fmMTFExample.xaml
    /// </summary>
 public partial class fmMTFExample : Window
    {
        int image = 1;
        bool open = false;
   
        public fmMTFExample()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.LoadImage(@"image\DataBase\1.png",imMTF);
            lbInscription.Content = "Записи файлов и катологов в главной файловой таблице MTF";
        }

        private void imMTF_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (image==1)
            {
                Helper.LoadImage(@"image\DataBase\2.png", imMTF);
                image = 2;
                lbInscription.Content = "Добавление атрибутов и потоков данных к записи MTF";
                ;
            }
            else
            {
                Helper.LoadImage(@"image\DataBase\1.png", imMTF);
                image = 1;
                lbInscription.Content = "Записи файлов и катологов в главной файловой таблице MTF";
            }
            
        }

        private void lbPreviousWin_MouseEnter(object sender, MouseEventArgs e)
        {
            //lbPreviousWin.Foreground = Brushes.Coral;
        }

        private void lbPreviousWin_MouseLeave(object sender, MouseEventArgs e)
        {
           // lbPreviousWin.Foreground = Brushes.Black;
        }

        private void lbPreviousWin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmModelDB form = new fmModelDB();
            form.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fmModelDB form = new fmModelDB();
            form.Show();
        }
    }
}
