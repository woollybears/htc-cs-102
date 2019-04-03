using Shapes;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;
            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);
            myCanvas.Children.Add(myRect);

           Diamond Dim2 = new Diamond();
            Dim2.Height = 100;
            Dim2.Width = 100;
            Dim2.Fill = Brushes.CornflowerBlue;
            Dim2.Stroke = Brushes.Pink;
            Dim2.StrokeThickness = 40;
            Canvas.SetLeft(Dim2, 200);
            Canvas.SetTop(Dim2, 200);
            myCanvas.Children.Add(Dim2);
        }
    }
}
