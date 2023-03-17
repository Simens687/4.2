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

namespace WpfApp2._4
{
    /// <summary>
    /// Логика взаимодействия для DobTip.xaml
    /// </summary>
    public partial class DobTip : Window
    {
        public DobTip()
        {
            InitializeComponent();
        }

        private void Save_new_tip(object sender, RoutedEventArgs e)
        {
            Ser_Des.Serialize<string>(Name_tip.Text, "Tips.json", 2);

            Close();
        }
    }
}
