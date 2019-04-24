using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WoollyBearsDataBase
{
    public class Woolly : Caterpillar
    {
        
        string woollyColor;
        string ownerName;


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
            MessageBox.Show(woollyName + Environment.NewLine + woollyColor + Environment.NewLine + woollyType + Environment.NewLine + ownerName + Environment.NewLine + woollyLength + Environment.NewLine+ "Thank you for creating a woolly bear! Create more!");
        }
    }

    
}
