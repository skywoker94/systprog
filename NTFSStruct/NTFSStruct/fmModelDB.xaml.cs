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
    /// Логика взаимодействия для fmModelDB.xaml
    /// </summary>
    public partial class fmModelDB : Window
    {
        bool open=false;
        public fmModelDB()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\BDModel.txt");

        }

        private void lbExampleMTF_MouseEnter(object sender, MouseEventArgs e)
        {
            lbExampleMTF.Foreground = Brushes.Coral;
        }

        private void lbExampleMTF_MouseLeave(object sender, MouseEventArgs e)
        {
            lbExampleMTF.Foreground = Brushes.Black;
        }

        private void lbExampleMTF_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmMTFExample form = new fmMTFExample();
            form.Show();
            open = true;
            this.Close();
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            lbBack.Foreground=Brushes.Coral;
           
        }

        private void lbPreviousWin_MouseLeave(object sender, MouseEventArgs e)
        {
          lbBack.Foreground = Brushes.Black;
        }

        private void lbPreviousWin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmModelNTFS form = new fmModelNTFS();
            form.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                fmModelNTFS form = new fmModelNTFS();
                form.Show();
            }
        }

        private void lbBack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void lbBack_MouseLeave(object sender, MouseEventArgs e)
        {
            lbBack.Foreground=Brushes.Black;
        }
    }
}
