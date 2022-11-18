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
    /// Логика взаимодействия для Answers.xaml
    /// </summary>
    public partial class Answers : Page
    {
        public Answers()
        {
            InitializeComponent();
        }

        private void M1_Click(object sender, RoutedEventArgs e)
        {
            if (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true)
            {
                MessageBox.Show("Ваша оценка: 5. Ну тут сразу понятно что ты студент 402 группы.");
            }
            else if ((Q1Frame.QRB1.IsChecked == false && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true)
                  || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == false && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true)
                  || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == false && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true) 
                  || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == false && Q5Frame.QRB5.IsChecked == true) 
                  || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == false))
            {
                MessageBox.Show("Ваша оценка: 4. Отлично.");
            }
            else if ((Q1Frame.QRB1.IsChecked == false && Q2Frame.QRB2.IsChecked == false && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true)
                 || (Q1Frame.QRB1.IsChecked == false && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == false && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true)
                 || (Q1Frame.QRB1.IsChecked == false && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == false && Q5Frame.QRB5.IsChecked == true)
                 || (Q1Frame.QRB1.IsChecked == false && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == false)
                
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == false && Q3Frame.QRB3.IsChecked == false && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == true) 
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == false && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == false && Q5Frame.QRB5.IsChecked == true) 
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == false && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == false) 
                
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == false && Q4Frame.QRB4.IsChecked == false && Q5Frame.QRB5.IsChecked == true) 
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == false && Q4Frame.QRB4.IsChecked == true && Q5Frame.QRB5.IsChecked == false) 
                
                || (Q1Frame.QRB1.IsChecked == true && Q2Frame.QRB2.IsChecked == true && Q3Frame.QRB3.IsChecked == true && Q4Frame.QRB4.IsChecked == false && Q5Frame.QRB5.IsChecked == false))
            {
                MessageBox.Show("Ваша оценка: 3. Да это же эталон оценки 4 курса. Неплохо.");
            }
            else
            {
                MessageBox.Show("Ваша оценка: 2. Либо ты не студент группы 402, либо ты ещё не 4-ый курс.");
            }
        }
    }
}
