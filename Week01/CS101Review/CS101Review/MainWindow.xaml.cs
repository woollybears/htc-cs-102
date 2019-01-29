using System.Windows;

namespace CS101Review
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the text value from our name text box, store it in the name variable
            string name = txtName.Text;

            // Say hello
            MessageBox.Show("Hello, " + name);

            // Conditionals
            /*
            if (name == "LeBron James")
            {
                // If they are Lebron, :(
                MessageBox.Show("Why did you leave us 😢");
            }
            else if (name == "Kevin Love")
            {
                // If they are Kevin, <3
                MessageBox.Show("You are our only hope <3");
            }
            else
            {
                // Anyone else does not matter
                MessageBox.Show("I don't really care about you");
            }
            */

            // Get the value from our age text box, converting it to an int
            int age = int.Parse(txtAge.Text);

            // Boolean logic
            /*
            if (age > 12 && age < 20)
            {
                // Age is between 13-19. Could also use (age >= 13 && age <= 19)
                MessageBox.Show("I don't like you, you're a teen");
            }

            if (age <= 5 || age >= 90)
            {
                // Age is 5 or younger, OR 90 or older
                MessageBox.Show("You are either too old or too young");
            }
            */

            // For loops
            /*
            for (int i = 0; i < 20; i++)
            {
                MessageBox.Show("Am I annoying you yet?");
            }
            */

            // Switch statements
            /*
            switch(name)
            {
                case "LeBron James":
                    MessageBox.Show("Why did you leave us 😢");
                    break;
                case "Kevin Love":
                    MessageBox.Show("You are our only hope <3");
                    break;
                default:
                    MessageBox.Show("I don't really care about you");
                    break;
            }
            */

            // Collections
            /*
            string[] messages = new string[3]; // define the array

            messages[0] = "You are cool"; // add elements to the array
            messages[1] = "Happy birthday";
            messages[2] = "I hope you have a good day";

            for (int i = 0; i < messages.Length; i++) // loop through the array
            {
                // show the messages from the array
                MessageBox.Show(messages[i]);
            }
            */

            // Functions
            /*
            ShowMessages("Top Message", "Bottom Message"); // call the function
            */
        }

        // Function definition
        public string ShowMessages(string message1, string message2)
        {
            string combinedMessage = message1 + "\n" + message2;
            MessageBox.Show(combinedMessage);
            return combinedMessage;
        }
    }
}
