using InheritanceIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Frog:animal
    {
        public string IsPoisonous;

        public void Ribbit()
        {
            MessageBox.Show("Ribbit!");
        }
        public Frog(string ispoisonous, string name)
        {
            IsPoisonous = ispoisonous;
            Name = name;
        }
    }
}
