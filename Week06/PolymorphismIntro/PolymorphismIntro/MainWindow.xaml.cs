﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();
            Frog frog = new Frog(4, "Kermit", false,12);
            Duck duck = new Duck(10, "Donald",13);
            Dog dog = new Dog("Rapper", 10, "Snoop Dawg",24);
            Dog dog2 = new Dog("Big Red Dog", 200, "Clifford", 1000);
            Duck duck2 = new PolymorphismIntro.Duck(12, "Daffy", 23);
            Frog frog2 = new PolymorphismIntro.Frog(3, "Jeremiah", true, 15);

            Animals.Add(frog);
            Animals.Add(duck);
            Animals.Add(dog);
            Animals.Add(frog2);
            Animals.Add(duck2);
            Animals.Add(dog2);
            lvAnimals.ItemsSource = Animals;

        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Animal animal in Animals)
            {
                animal.SayName();
            }
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (object selectedItem in lvAnimals.SelectedItems)
            {

                Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
                if (selectedAnimal != null)
                {
                    Dog dog = selectedAnimal as Dog;
                    if(dog != null)
                    {
                        dog.Bark();
                    }
                    selectedAnimal.Speak();
                }
            }
        }
    }
}




























































































































































