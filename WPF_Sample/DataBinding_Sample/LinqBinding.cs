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
using System.Xml.Linq;

namespace DataBinding_Sample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ButtonNameT_Click_1(object sender, RoutedEventArgs e)
        {
            XDocument doc = XDocument.Load(@"..\..\StuInfo.xml");
            listviewLinq.ItemsSource =
                from element in doc.Descendants("student")
                where element.Element("Name").Value.StartsWith("T")
                select new Student()
                {
                    Id = element.Attribute("Id").Value,
                    Name = element.Element("Name").Value,
                };
        }
    }
}
