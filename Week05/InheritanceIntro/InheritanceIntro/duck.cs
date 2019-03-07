using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class duck:animal
    {
        
        public void Quack()
        {
            MessageBox.Show("Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack! Quack!");
        }

     
        public duck(int height, string name)
        {
            Height = height;
            Name = name;
        }    
    }
}
