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
        private void ValidationRuleBinding()
        {
            Binding bd = new Binding("Value")
            {
                Source = sliderValid
            };
            Validation v = new Validation();
            v.ValidatesOnTargetUpdated = true;
            bd.ValidationRules.Add(v);
            bd.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            textboxValid.SetBinding(TextBox.TextProperty, bd);
            
        }
    }
    public class Validation : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d > 0 && d < 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "ERROR");
        }

    }
}
