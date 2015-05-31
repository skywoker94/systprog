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

        private void imSmallCatalog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Атрибуты небольшого каталога, подобно атрибутам небольшого файла могут быть резидентными в MFT. В случае небольшого каталога атрибут корня индекса индекса содержит индекс файловых ссылок для файлов и подкаталогов.";
        }

        private void imBigCatalog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Конечно, многие файлы и катологи не удается втиснуть в запись MFT – структуру данных размером 1,2,4 Кбайт. Если некоторый атрибут , например, атрибут данных файла, слишком велик, чтобы поместиться в файловою запись MFT, то NTFS выделяет на диске область размером 2 Кбайт, отдельную от MFT. В этой области, называемым отрезком, или экстентом, хранится значение атрибута (например данные файла). Если затем размер значения атрибута увеличивается (допустим , если пользователь дописывает к концу файла новые данные), то для дополнительных данных NTFS выделяет еще один отрезок. Атрибуты, значения которых храниться не в MFT, а в отрезках, называющихся нерезидентными атрибутами. Файловая система определяет, является ли данный атрибут резидентным или нерезидентным; способ размещения данных прозрачен для программы, осуществляющий доступ к ним. Большой каталог также может  иметь нерезидентные атрибуты (или части атрибутов). Если в файловой записи MFT недостаточно места для хранения индекса фалов, составляющий этот большой каталог, часть индекса хранится в атрибуте корня индекса, в его остаток находится в нерезидентных отрезках, называемых индексными буферами. Атрибуты стандартной  информации и имени файла всегда резидентные. Заголовок и, по крайней мере, часть значения атрибута корня индекса для каталогов также резидентные.";
        }

        private void imIndexBuf_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Индексный буфер - отрезок, равный 2 Кбайт или размеру кластера (в зависимости от того, что больше), содержащий часть индекса. Индексные буферы реализуют структуру данных b+ дерево, используемую для сортировки записей индекса. b+ дерево – структура данных, представляющая собой сбалансированное дерево, растущее в ширину, а не в глубину, благодаря чему минимизируется число обращений к диску, необходимое для поиска нужной записи. NTFS использует b+ дерево для хранения  индексов имен файлов.";
        }

        private void imVirt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "В том случае, когда атрибуты файла (или каталога) не умещаются в MFT и требуется выделение дополнительного пространства, NTFS отслеживает эти отрезки при помощи виртуальных номеров кластеров(VCN). Логические номера кластеров (LCN) представляют последовательность кластеров всего тома от 0 до n. VCN же нумеруют от 0 до m кластеры, принадлежащие данному файлу. Если бы этот файл занимал боле двух отрезков, то нумерация третьего отрезка начиналась бы с VCN в LCN для обоих отрезков что позволит NTFS легко находить данные на диске";
        }
    }
}
