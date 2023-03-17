using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp2._4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Date.SelectedDate = DateTime.Now;

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(desktop + "\\Практика_2.4_по_шарпу");

            List<string> tips_ = new List<string>();
            tips_ = Ser_Des.Deserialize<List<string>>("Tips.json");
            try
            {
                int i = -1;
                while (true) { i += 1; Tips.Items.Add(tips_[i]); }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Dob_tip(object sender, RoutedEventArgs e)
        {
            DobTip subWindow = new DobTip();
            subWindow.Show();
        }

        private void Obnov_tip(object sender, ContextMenuEventArgs e)
        {
            List<string> tips_ = new List<string>();
            tips_ = Ser_Des.Deserialize<List<string>>("Tips.json");
            try
            {
                int i = -1;
                while (true) { i += 1; Tips.Items.Add(tips_[i]); }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
