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

namespace wpft2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);
            lstNames.Items.Add($"{rInt} was added at {DateTime.Now}");
            listView.Items.Add($"{rInt}");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedIndex >= 0)
            {
                lstNames.Items.Add($"{listView.SelectedIndex} was removed at {DateTime.Now}");
                listView.Items.RemoveAt(listView.SelectedIndex);
            }
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add($"{n1.Content} was pressed at {DateTime.Now}");
            MessageBox.Show($"Hei {n1.Content}");
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add($"{n2.Content} was pressed at {DateTime.Now}");
            MessageBox.Show($"Hei {n2.Content}");
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add($"{n3.Content} was pressed at {DateTime.Now}");
            MessageBox.Show($"Hei {n3.Content}");
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add($"{n4.Content} was pressed at {DateTime.Now}");
            MessageBox.Show($"Hei {n4.Content}");
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstNames_MouseEnter(object sender, MouseEventArgs e)
        {
            lstNames.Items.Add($"Mouse enterd at {DateTime.Now}");
        }

        private void lstNames_MouseLeave(object sender, MouseEventArgs e)
        {
            lstNames.Items.Add($"Mouse left at {DateTime.Now}");
        }

        private void lstNames_MouseMove(object sender, MouseEventArgs e)
        {
            lstNames.Items.Add($"Mouse was moving at {DateTime.Now}");
        }
    }
}
