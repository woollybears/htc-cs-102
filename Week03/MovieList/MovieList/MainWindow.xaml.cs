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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public List<Movie> MovieList;
        public MainWindow()
        {
            InitializeComponent();
            MovieList = new List<Movie>();
        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
