using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DataBinding_Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ButtonXML_Click_1(object sender, RoutedEventArgs e)
        {
            XmlDataProvider xpd = new XmlDataProvider();
            xpd.Source = new Uri(@"D:\MyProject\GitHub\WPF_Training_Sample\WPF_Sample\DataBinding_Sample\StuInfo.xml");
            xpd.XPath = @"/students/student";

            listviewXML.DataContext = xpd;
            listviewXML.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
