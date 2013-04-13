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

namespace Event_Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            g1.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click_1));
        }

        private void Grid_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Grid g = sender as Grid;
            MessageBox.Show(g.Name);
            e.Handled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameworkElement f = sender as FrameworkElement;
            MessageBox.Show(f.Name);
        }
    }
}
