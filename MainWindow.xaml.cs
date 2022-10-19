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

namespace ISRPO_Palashicheva_PR9
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

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            string a = Convert.ToString(Dany.Content);
            //счет идет с первой буквы(с 0). Метод IndexOf может осуществлять поиск подстроки в строке
            int index = a.IndexOf("OP");
            Itog.Content = Convert.ToString(index);
            //метод Substring возвращает часть строки указанной длины, начинаяс указанной позиции:
            string b = a.Substring(3, 5);
            Itog2.Content = Convert.ToString(b);
        }

        private void Win1_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
        }

        private void Win2_Click(object sender, RoutedEventArgs e)
        {
            Window2 a2 = new Window2();
            a2.Show();
        }
    }
}
