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
            MessageBox.Show("The name of you woolly bear is " + woollyName + "!" + Environment.NewLine + "The Color of you woolly bear is " + ownerName + "!" +  Environment.NewLine + "Your woolly bear's type is " + woollyType + "!" + Environment.NewLine +  "Your Name is " + woollyColor + "!" + Environment.NewLine +  "The Length of your woolly bear is "+ woollyLength + "!" + Environment.NewLine+ "Thank you for creating a woolly bear! Create more!");
        }
    }

    
}
