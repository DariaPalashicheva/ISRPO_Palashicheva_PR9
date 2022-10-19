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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int len;
            string text;

            if (phonesList.SelectedItem != null)
            {
                //получаем доступ к элементу
                ListBoxItem li = (ListBoxItem)phonesList.Items[phonesList.SelectedIndex];
                //получаем текст
                text = (string)li.Content;
                len = text.Length;

                //считаем, что кол-во пробелов равно 0
                int count = 0;
                // устанавливаем счетчик символов в 0
                int i = 0;
                // организуем цикл перебора всех символов в строке
                while (i < len - 1)
                {
                    // если нашли пробел, то увеличиваем счетчик пробелов на 1
                    if (text[i] == ' ')
                        count++;
                    i++;
                }
                Schet.Text = Convert.ToString(count+1);
            }

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            int m = Int32.Parse(tb1.Text) - 1, j = Int32.Parse(tb2.Text) - 1;


                //получаем доступ к элементу
                ListBoxItem li = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(1));
                me.Text = li.Content.ToString();
                string[] stroka = me.Text.Split(' ');
                foreach (var t in stroka)
                {
                    itogg.Text += zamena(t, m, j) + Environment.NewLine;
                }

        }
        static string zamena(string text, int pos1, int pos2)
        {
            char[] swap = text.ToCharArray();
            char temp = swap[pos1];
            swap[pos1] = swap[pos2];
            swap[pos2] = temp;
            return new string(swap);
        }

    }
}
