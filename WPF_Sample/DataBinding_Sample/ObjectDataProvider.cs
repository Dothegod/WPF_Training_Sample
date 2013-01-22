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
    class Cal
    {
        public string Add(string str1, string str2)
        {
            double x, y, z;
            if (Double.TryParse(str1,out x)&&Double.TryParse(str2,out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "ERROR";
        }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ObjectDataProviderBinding()
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Cal();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            Binding bd1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,   //将UI收集到的数据写入直接source
                UpdateSourceTrigger = UpdateSourceTrigger.Default
                
            };
            Binding bd2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.LostFocus
                
            };
            Binding bindingResult = new Binding(".")
                {
                    Source=odp
                };
            tbArg1.SetBinding(TextBox.TextProperty, bd1);
            tbArg2.SetBinding(TextBox.TextProperty, bd2);
            tbResult.SetBinding(TextBox.TextProperty, bindingResult);


        }
    }
}
