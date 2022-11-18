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
    /// Логика взаимодействия для Question3.xaml
    /// </summary>
    public partial class Question3 : Page
    {
        public Question3()
        {
            InitializeComponent();
            Q3Frame.QRB3 = A3;
        }

        private void NQ_Click(object sender, RoutedEventArgs e)
        {
            if (A1.IsEnabled || A2.IsEnabled || A3.IsEnabled || A4.IsEnabled)
            {
                AppFrame.frameMain.Navigate(new Question4());
            }
        }

        private void GB_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
