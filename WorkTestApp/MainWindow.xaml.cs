
using System.Windows;


namespace WorkTestApp
{
  
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();         

        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            SumMod.Text=Logic.SumModCalculation(out string str);
            Massive.Text = str;
        }
        private void Click_Button_2(object sender, RoutedEventArgs e)
        {
            SumTwoLinkedLists.Text = Logic.SumTwoLinkedListsCalc(out string str1, out string str2);
            FirstLinkedList.Text = str1;
            SecondLinkedList.Text = str2;            
        }
        private void Click_Button_3(object sender, RoutedEventArgs e)
        {
            Result.Text = Logic.isPalindromAlg(TextB.Text);
        }
    }
}
