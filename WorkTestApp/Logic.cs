using System;
using System.Collections.Generic;
using System.Windows;


namespace WorkTestApp
{
    public static class Logic
    {
        public static string SumModCalculation(out string str1)
        {
            var mas = new int[15];
            var rand = new Random();
            for (int i = 0; i < mas.Length; i++) mas[i] = rand.Next(-200, 201);
            str1 = $"[{string.Join(",", mas)}]";
            return FirstApp.SumMod(mas).ToString();
        }
        public static string SumTwoLinkedListsCalc(out string str1, out string str2)
        {
            var firstList = new LinkedList<int>();
            var secondList = new LinkedList<int>();
            var rand = new Random();
            var latestI = rand.Next(1, 5);
            for (int i = 0; i < latestI; i++) firstList.AddLast(rand.Next(1, 10));
            latestI = rand.Next(1, 5);
            for (int i = 0; i < latestI; i++) secondList.AddLast(rand.Next(1, 10));
            str1 = $"[{string.Join(",", firstList)}]";
            str2 = $"[{string.Join(",", secondList)}]";
            return $"[{string.Join(",", SecondApp.SumTwoLists(firstList, secondList))}]";
        }
        public static string isPalindromAlg(string str)
        {
            if (str == "")
            {
                MessageBox.Show("Пустая строка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return String.Empty;
            }
            else
            {
                if (ThirdApp.IsPalindrome(str)) return "Строка палиндром";
                else return "Строка не палиндром";
            }
        }
    }
}
