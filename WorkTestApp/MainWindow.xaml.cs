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

            


        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
                     
            var mas = new int[15];
            var rand = new Random();
            for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(-200, 201);            
            Massive.Text = $"[{string.Join(",",mas)}]";
            SumMod.Text = FirstApp.SumMod(mas).ToString();
            
        }
        private void Click_Button_2(object sender, RoutedEventArgs e)
        {

            var firstList = new LinkedList<int>();
            var secondList = new LinkedList<int>();
            var rand = new Random();
            var latestI = rand.Next(1, 5);
            for (int i = 0; i < latestI; i++) firstList.AddLast(rand.Next(1,10));
            latestI = rand.Next(1, 5);
            for (int i = 0; i < latestI; i++) secondList.AddLast(rand.Next(1, 10));           
            FirstLinkedList.Text = $"[{string.Join(",", firstList)}]"; 
            SecondLinkedList.Text= $"[{string.Join(",", secondList)}]";            
            SumTwoLinkedLists.Text= $"[{string.Join(",", SecondApp.SumTwoLists(firstList, secondList))}]";
            
        }
        private void Click_Button_3(object sender, RoutedEventArgs e)
        {
            if (TextB.Text == "") MessageBox.Show("Пустая строка","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (ThirdApp.IsPalindrome(TextB.Text)) Result.Text = "Строка палиндром";
                else Result.Text = "Строка не палиндром";
            }

        }
    }
}
