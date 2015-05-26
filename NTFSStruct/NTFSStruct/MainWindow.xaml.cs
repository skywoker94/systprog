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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NTFSStruct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbStart_MouseEnter(object sender, MouseEventArgs e)
        {
            lbIntroduction.Foreground = Brushes.Coral;
        }

        private void lbStart_MouseLeave(object sender, MouseEventArgs e)
        {
            lbIntroduction.Foreground = Brushes.Black;
        }

        private void lbIntroduction_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmIntroduction form = new fmIntroduction();
            form.Show();
            this.Close();
        }

        private void lbModels_MouseEnter(object sender, MouseEventArgs e)
        {
            lbModels.Foreground = Brushes.Coral;
        }

        private void lbModels_MouseLeave(object sender, MouseEventArgs e)
        {
            lbModels.Foreground = Brushes.Black;
        }

        private void lbModels_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmModelNTFS form = new fmModelNTFS();
            form.Show();
            this.Close();
        }

        private void lbNTFSStruct_MouseEnter(object sender, MouseEventArgs e)
        {
            lbNTFSStruct.Foreground = Brushes.Coral;
        }

        private void lbNTFSStruct_MouseLeave(object sender, MouseEventArgs e)
        {
            lbNTFSStruct.Foreground = Brushes.Black;
        }

        private void lbNTFSStruct_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmStructNTFS form = new fmStructNTFS();
            form.Show();
            Close();
        }

    }
}
