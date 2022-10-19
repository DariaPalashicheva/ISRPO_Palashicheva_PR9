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

namespace ISRPO_Palashicheva_PR9
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(1));
            TextBlock.Text = lbi.Content.ToString();
            ListBoxItem lbi4 = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(4));
            TextBlock4.Text = lbi4.Content.ToString();
        }
    }
}
