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
    class Student : INotifyPropertyChanged
    {
        private string m_Name;
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.Name = "Jim";
            Binding bd = new Binding();
            bd.Source = st;
            bd.Path = new PropertyPath("Name");
            BindingOperations.SetBinding(tbCode, TextBox.TextProperty, bd);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.Name = "Mike";
            tbCode1.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = st });
        }
    }
}
