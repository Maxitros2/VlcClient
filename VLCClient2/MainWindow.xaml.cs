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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace VLCClient2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vlcLibDirectory = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            var options = new string[]
            {
                
            };

           
        

        }
    }
}
