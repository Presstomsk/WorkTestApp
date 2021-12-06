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

namespace WorkTestApp
{
  
    public partial class MainWindow : Window
    {
        /* LinkedList<int> one; 

         LinkedList<int> two; 
         LinkedList<int> result; */
        /*List<int> nev = new List<int>() {4,4,3,6,7,3,8,8,4,8,9,5,6,7 };*/
        public MainWindow()
        {
            InitializeComponent();

            //MessageBox.Show($"{ThirdApp.IsPalindrome("А роза упала, на лапу Азора")}");
            /*one = new LinkedList<int>();
            two= new LinkedList<int>();
            result = new LinkedList<int>();
            one.AddLast(5);
            one.AddLast(8);
            one.AddLast(4);
            one.AddLast(7);
            two.AddLast(4);
            two.AddLast(6);
            two.AddLast(5);

            result = SecondApp.SumTwoLists(one, two);
            var item = result.First;
            string str=String.Empty;
            while (item != null)
            {
                str += item.Value.ToString();
                item = item.Next;
            }
            New.Text = str;*/

            //New.Text=FirstApp.SumMod(nev).ToString();


        }


    }
}
