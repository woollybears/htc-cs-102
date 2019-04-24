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

namespace WoollyBearsDataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Woolly> WoollyBears;
        public MainWindow()
        {
            WoollyBears = new List<Woolly>();

        }

        

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            string oname = onamebox.Text;
            string name = namebox.Text;
            string type = typebox.Text;
            int length = Convert.ToInt32(lengthbox.Text);
            string color = colorbox.Text;
            Woolly newWoolly = new Woolly(name, oname, type, length, color);
            WoollyBears.Add(newWoolly);
            foreach (Woolly woolly in WoollyBears)
            {
                woolly.ShowWoolly();
               
            }
        }
    }
}
