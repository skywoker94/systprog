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
            Helper.LoadImage(@"image\void.png", imFileObj);
            Helper.LoadImage(@"image\void.png", imProc);
            Helper.LoadImage(@"image\void.png", imTable);
            Helper.LoadImage(@"image\void.png", imFileBlock);

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

        private void imFileObj_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\6.png", imScheme);
        }

        private void imFileObj_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imFileObj_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Файловый объект - это объект, видимый из режима пользователя, который представляет всевозможные открытые источники или приемники ввода/вывода: файл на диске или устройство (физическое, логическое, виртуальное).";
        }

        private void imProc_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\8.png", imScheme);
        }

        private void imProc_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imProc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Процесс Windows по своей сути является контейнером, в котором хранится код команд из исполняемого файла. Он представляет собой объект процесса ядра и Windows использует этот объект процесса и связанные с ним структуры данных для хранения и сопровождения информации об исполняемом коде приложения. Например, процесс имеет виртуальное адресное пространство, в котором хранятся его частные и общие данные и в которое отображаются исполняемый образ и связанные с ним библиотеки DLL. Windows с помощью инструментов диагностики записывает информацию об использовании процессом ресурсов для обеспечения учета и выполнения запросов и регистрирует ссылки процесса на объекты операционной системы в таблице дескриптора процесса. Процессы работают с контекстом безопасности, именуемом маркером, который идентифицирует учетную запись пользователя, группы учетной записи и привилегии, назначенные процессу.";
        }

        private void imTable_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void imTable_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\7.png", imScheme);
        }

        private void imTable_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);
        }

        private void imTable_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Описатель (handle) это элемент таблицы, содержащий маску предоставленного доступа (granted access) и указатель на объект ядра. Таблица описателей для каждого процесса своя: указатель на таблицу содержится в поле nt!_EPROCESS.ObjectTable. Из этого следует, что описатель содержит в себе информацию о предоставленном конкретному процессу доступе к объекту ядра.";
        }

        private void imConrolBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Структура данных NTFS, используемая для поиска файла на диске по указателю на файловй объект. SCB представляет один атрибут (поток) открытого файла и содержит ссылку на блок управления этим файлом.";
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\9.png", imScheme);
        }

        private void imFileBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\ObjectModel\1.png", imScheme);

        }

        private void imFileBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Блок управления файлом - структура данных NTFS, которая используеся для поиска файла на диске по указателю на файловый объект. Блок представляет собой один открытый файл и содержит его файловую ссылку.";
        }

        private void imDataBase_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Главная файловая таблица (MFT) – база данных, в которой хранится информация о содержании тома NTFS. MFT представляет собой таблицу, ряды которой соответствуют файлам тома, а колонки – атрибутам файлов.";
        }


      
    }
}
