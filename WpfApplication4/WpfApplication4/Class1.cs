using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WoollyBearsDataBase
{
    public class Woolly
    {
        string woollyName;
        string woollyColor;
        private int woollyLength;
        private string woollyType;
        private string ownerName;


        public Woolly(string name, string color, string type, int length, string oname)
        {
            this.woollyName = name;
            this.woollyColor = color;
            this.woollyType = type;
            this.woollyLength = length;
            this.ownerName = oname;
        }

        public void ShowWoolly()
        {
            MessageBox.Show(woollyName + Environment.NewLine + woollyColor + Environment.NewLine + woollyType + Environment.NewLine + ownerName);
        }
    }

    }
