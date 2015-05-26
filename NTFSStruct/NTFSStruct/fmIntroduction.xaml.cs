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
    /// Логика взаимодействия для fmIntroduction.xaml
    /// </summary>
    public partial class fmIntroduction : Window
    {
        public fmIntroduction()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text= File.ReadAllText(@"txt/Introduction.txt");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
        }
    }
}
