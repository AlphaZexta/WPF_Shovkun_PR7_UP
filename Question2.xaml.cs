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
    /// Логика взаимодействия для Question2.xaml
    /// </summary>
    public partial class Question2 : Page
    {
        public Question2()
        {
            InitializeComponent();
            Q2Frame.QRB2 = A2;
        }

        private void NQ_Click(object sender, RoutedEventArgs e)
        {
            if (A1.IsEnabled || A2.IsEnabled || A3.IsEnabled || A4.IsEnabled)
            {
                AppFrame.frameMain.Navigate(new Question3());
            }
        }

        private void GB_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }
    }
}
