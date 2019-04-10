using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Input;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EllipseGeometry myEllipseGeometry;

        public MainWindow()
        {
            InitializeComponent();
            Path myPath = new Path();
            myPath.Fill = Brushes.IndianRed;
            myPath.Data = myEllipseGeometry;
            myCanvas.Children.Add(myPath);

            myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(200, 200);
            myEllipseGeometry.RadiusX = 20;
            myEllipseGeometry.RadiusY = 20;

            Path myDog = new Path();
            myPath.Fill = Brushes.IndianRed;
            myPath.Data = myEllipseGeometry;

            myCanvas.Children.Add(myDog);
           


        }



        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(666));
            myEllipseGeometry.BeginAnimation(EllipseGeometry.CenterProperty, myPointAnimation);
        }
    }
}
