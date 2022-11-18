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

namespace WPF_Shovkun_PR7_UP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.frameMain = FrmMain;
        }

        private void ST_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new Question1());
            ST.Visibility = Visibility.Hidden;
        }

        private void ET_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
