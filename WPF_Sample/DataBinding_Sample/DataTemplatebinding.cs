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
        private void DataTemplateBinding()
        {
            List<Student> stus = new List<Student>()
            {
                new Student(){Id="1", Name="Tom", Age="15"},
                new Student(){Id="2", Name="Jim", Age="15"},
                new Student(){Id="3", Name="Lily", Age="15"},
                new Student(){Id="4", Name="Lucy", Age="15"},
                new Student(){Id="5", Name="Tim", Age="15"}
            };
            lisboxDataTemplatebinding.ItemsSource = stus;
        }
    }
}
