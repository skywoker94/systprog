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
    /// Логика взаимодействия для fmDriverModel.xaml
    /// </summary>
    public partial class fmDriverModel : Window
    {
        private bool open = false;
        public fmDriverModel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbText.Text = File.ReadAllText(@"txt\DriverModel.txt");
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
            Helper.LoadImage(@"image\void.png",imClick);
            Helper.LoadImage(@"image\void.png", imSubsystemEnvironment);
            Helper.LoadImage(@"image\void.png", imManObj);
            Helper.LoadImage(@"image\void.png", imMonitor);
            Helper.LoadImage(@"image\void.png", imManProc);
            Helper.LoadImage(@"image\void.png", imLPC);
            Helper.LoadImage(@"image\void.png", imMemoryManager);
            Helper.LoadImage(@"image\void.png", imCore);

        }

        private void imDriverModel_MouseEnter(object sender, MouseEventArgs e)
        {
           
            Helper.LoadImage(@"image\driver\first\10.png", imDriverModel);

        }

        private void imDriverModel_MouseLeave(object sender, MouseEventArgs e)
        {
           
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imDriverModel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            fmDriverModel2 form = new fmDriverModel2();
            form.Show();
            open = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!open)
            {
                fmModelNTFS form = new fmModelNTFS();
                form.Show();
            }
        }

        private void imSubsystemEnvironment_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\3.png", imDriverModel);
        }

        private void imSubsystemEnvironment_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imSubsystemEnvironment_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Подсистема окружения разработана для запуска приложений, написанных для разных типов операционных систем. Ни одна из подсистем окружения не имеет прямого доступа к аппаратной части компьютера. Доступ к ресурсам памяти происходит посредством Менеджера Виртуальной Памяти, который работает в режиме ядра. Также приложения запускаются с меньшим приоритетом, чем процессы режима ядра.";
        }

        private void imManObj_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void imManObj_DragLeave(object sender, DragEventArgs e)
        {
           
        }

        private void imManObj_DragEnter(object sender, MouseEventArgs e)
        {
        }

        private void imManObj_DragLeave(object sender, MouseEventArgs e)
        {

        }

        private void imManObj_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\4.png", imDriverModel);
        }

        private void imManObj_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imManObj_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Диспетчер объектов предоставляет набор универсальных сервисов, применимых к объектам любого типа. Кроме того, другие компоненты исполнительной системы NT обеспечивают типозависимые сервисы для создаваемых ими типов объектов. Эти сервисы вызывают диспетчер объектов посредством внутренних интерфейсов. Следовательно, все сервисы, которые работают с объектами, должны на том или ином уровне пройти через диспетчер объектов. Это позволяет последнему централизовать управление объектами и выполнять все соответствующие задачи (или явным образом передавать управление вторичному диспетчеру объектов, если необходимо).";
        }

        private void imMinitor_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\5.png", imDriverModel);
        }

        private void imMonitor_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imMonitor_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Справочный монитор защиты (security reference monitor) отвечает за реализацию единой политики защиты на локальном компьютере. Оберегает ресурсы ОС, обеспечивая защиту объектов и аудит во время выполнения доступа к ним. Справочный монитор защиты использует для реализации единой системной политики безопасности списки контроля доступа (Access Control Lists, ACL), содержащие информацию о том, какие процессы имеют доступ к конкретному объекту и какие действия они могут над ним выполнять, и идентификаторы безопасности (Security Identifiers, SI). Он поддерживает уникальный для каждого потока профиль защиты, и проверку полномочий при попытке доступа к объектам. При открытии потоком описателя объекта активизируется подсистема защиты, сверяя ACL, связанный с объектом, с запрашиваемыми потоком действиями над этим объектом. Другим аспектом справочного монитора защиты является поддержка имперсонации (impersonation), которая позволяет одному потоку передать другому право использования своих атрибутов защиты. Это наиболее часто используется во время клиент-серверных операций, когда сервер использует атрибуты защиты клиента.";
        }

        private void imManProc_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\6.png", imDriverModel);
        }

        private void imManProc_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imManProc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Диспетчер процессов (process manager или process structure) отвечает за создание и уничтожение процессов и потоков. Диспетчер процессов взаимодействует с диспетчером объектов для построения объекта-процесса и объекта-потока, а также взаимодействует с диспетчером памяти для выделения виртуального адресного пространства для процесса.";
        }

        private void imLPC_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\7.png", imDriverModel);
        }

        private void imLPC_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imLPC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Средство локального вызова процедур (LPC) организует взаимодействие между клиентскими и серверными процессами, расположенными на одном и том же компьютере. LPC - это гибкая, оптимизированная версия удаленного вызова процедур (Remote Procedure Call, RPC), средства коммуникации между клиентскими и серверными процессами по сети. LPC поддерживает передачу данных между клиентом и сервером посредством использования объектов-портов, которые в качестве атрибутов имеют указатель на очередь сообщений и описатель секции разделяемой памяти. API, необходимый для доступа к LPC, не документирован. Интересно, что запрос RPC между приложениями, исполняющимися на одном компьютере, в действительности будет использовать механизм LPC.";
        }

        private void imMemoryManager_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\8.png", imDriverModel);
        }

        private void imMemoryManager_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imMemoryManager_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text =
                "Диспетчер памяти и диспетчер кэша (memory manager и cache manager). Диспетчер памяти и диспетчер кэша вместе формируют подсистему виртуальной памяти. Эта подсистема виртуальной памяти реализует 32-разрядную страничную организацию памяти. Подсистема виртуальной памяти поддерживает совместное использование страниц физической памяти между несколькими процессами. Она поддерживает разделяемый сегмент памяти «только для чтения», а также «чтения-записи». Подсистема виртуальной памяти отвечает за реализацию механизма кэширования данных. Данные файла могут быть доступны через диспетчера ввода/вывода при использовании стандартных операций чтения и записи в файл, или через диспетчер памяти посредством проецирования данных файла напрямую в виртуальное пространство процесса. Чтобы гарантировать согласованность между этими двумя методами доступа, диспетчер кэша поддерживает единый глобальный общий кэш. Этот единый кэш используется для кэширования, как страниц процесса, так и страниц файла. Диспетчер памяти реализует схему управления памятью, которая предоставляет каждому процессу 4-гигабайтное собственное виртуальное адресное пространство и защищает его от других процессов. Диспетчер памяти реализует механизм подкачки страниц (paging) - перенос страниц физической памяти на диск и обратно. Диспетчер кэша повышает производительность файлового ввода/вывода, сохраняя информацию, считанную с диска последней, в системной памяти. Диспетчер кэша использует средство подкачки страниц диспетчера памяти для автоматической записи информации на диск в фоновом режиме.";
        }

        private void imCore_MouseEnter(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\9.png", imDriverModel);
        }

        private void imCore_MouseLeave(object sender, MouseEventArgs e)
        {
            Helper.LoadImage(@"image\driver\first\1.png", imDriverModel);
        }

        private void imCore_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtExplanation.Text = "Ядро осуществляет диспетчеризацию нитей, обработку прерываний и исключительных ситуаций. Если компьютер имеет многопроцессорную архитектуру, ядро повышает производительность системы, синхронизируя работу процессоров. В мультипроцессорной конфигурации ядро может одновременно выполняться на всех процессорах. Роль ядра заключается в том, чтобы обеспечить оптимальную загрузку всех процессоров и наилучшую производительность системы. Для этого ядро осуществляет диспетчеризацию нитей в соответствии с их приоритетами. Фактически, оно принудительным образом проводит политику диспетчеризации, реализуемую модулем Windows NT Executive. Кроме того, ядро вытесняет (preempt) нити с низким приоритетом в пользу более высокоприоритетных нитей. Оно может принудительным образом выполнять переключения контекста (context switches), давая процессору инструкции прекратить выполнение одной задачи и взяться за другую. Таким образом, код, выполняющийся в такой системе, должен быть реентерабельным (reentrant). Под реентерабельностью кода понимается способность прервать выполнение и быть выгруженным, а также возобновить выполнение без потери информации. Кроме того, реентерабельный код может совместно использоваться несколькими различными нитями, выполняющими различные строки одного и того же кода на различных процессорах. ";
        }

    }
}
