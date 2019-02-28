using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
       private string movieName;
        private int releaseYear;
        private string director;
        private int length;
        private string genre;

        public Movie (string name, int releaseYear, string director, int length, string genre )
        {
            this.movieName = name;
            this.releaseYear = releaseYear;
            this.director = director;
            this.length = length;
            this.genre = genre;
        }
        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear+ Environment.NewLine+ director + Environment.NewLine + length+ Environment.NewLine + genre);
        }
    }
}
