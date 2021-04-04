using System;
using System.Collections.Generic;
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

namespace Arrays
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

        string[] xname = new string[4];
        string[] xname2 = new string[4];
        string[] xsurname = { "Apple", "Orange", "Kiwi", "Banana" };



        private void button_Click(object sender, RoutedEventArgs e)
        {
            xname[0] = "Omega";
            xname[1] = "Delta";
            xname[2] = "Beta";
            xname[3] = "Alfa";

            foreach (var item in xname)
            {
                listBox1.Items.Add(item);
            }

            Array.Resize(ref xsurname, 6); // givinf new size to array
            xsurname[4] = "Mango"; // adding value to array
            xsurname.SetValue("Papaya", 5); // adding value to array

            foreach (var item in xsurname)
            {
                listBox2.Items.Add(item);
            }

            MessageBox.Show(xsurname.GetValue(3).ToString()); // get value of a specific index in array
            MessageBox.Show(string.Join("-", xname)); // combine all values of an array with a specific seperator character

            Array.Copy(xname, xname2, 3); // copy values of an array into another for given amount of values
            foreach (var item in xname2)
            {
                listBox3.Items.Add(item);
            }

            if (xname.Contains("Alfa")) // checks if array contains given value and returns true / false
            {
                int indexNo = Array.IndexOf(xname, "Alfa");
                int lenght = xname.Length;
                MessageBox.Show("There is an Alfa" + "\n" + "Index number : " + indexNo.ToString() + "lenght : " + lenght);
            }
        }

        private void button_sort_Click(object sender, RoutedEventArgs e)
        {
            Array.Sort(xname); // sort items from min to max / A to Z
            Array.Sort(xsurname); // sort items from min to max / A to Z
            Array.Reverse(xsurname); // reverse items

            listBox1.Items.Clear();
            foreach (var item in xname)
            {
                listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();
            foreach (var item in xsurname)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
