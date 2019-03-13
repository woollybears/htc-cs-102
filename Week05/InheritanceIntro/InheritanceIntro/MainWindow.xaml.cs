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

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            List<animal> animals = new List<animal>();
            // Define a new List of dogs
           // List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            animals.Add(dog1);
            animals.Add(dog2);

            // Loop through the list and call a method on the objects
            //foreach (Dog d in dogs)
           // {
            //    d.SayName();
           // }
            duck duck1 = new duck(25, "Harry");
            duck duck2=new duck (45, "Henrietta");
            //List<duck> ducks = new List<duck>();
            animals.Add(duck1);
            animals.Add(duck2);
            
            foreach (animal animal in animals)
            {
                animal.SayName();
                MessageBox.Show("The height is " + animal.Height);
            }
            Frog frog1 = new Frog("No" ,"Bo");
            Frog frog2 = new Frog("Yes", "Spiky");
            List<Frog> frogs = new List<Frog>();
            frogs.Add(frog1);
            frogs.Add(frog2);
            foreach(Frog frog in frogs)
            {
                frog.SayName();
            }
            
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            duck duck = new duck(0,"mom");
            duck.Quack();

        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog("Yes","mommy");
            frog.Ribbit();
        }
    }
}
