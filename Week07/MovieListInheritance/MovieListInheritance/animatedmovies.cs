using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class AnimatedMovie: Movie
    {
        public string AnimationStudio { get; set; }
        public string AnimationType { get; set; }

       public AnimatedMovie(string AnimationStudio, string AnimationType, int ReleaseYear, string Title)
        { 
        
            this.AnimationStudio = AnimationStudio;
            this.AnimationType = AnimationType;
            this.ReleaseYear = ReleaseYear;
            this.Title = Title;

        }
        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }
    }

}

