
using System.Collections.Generic;


namespace WorkTestApp
{
    public static class SecondApp
    {
        public static LinkedList<int> SumTwoLists(LinkedList<int> firstNumber, LinkedList<int> secondNumber)
        {
            
            var item1 = firstNumber.First;
            var item2 = secondNumber.First;

            if (firstNumber.Count > secondNumber.Count) return Sum(item1, item2);
            else return Sum(item2, item1);
            
            
        }

        private static LinkedList<int> Sum(LinkedListNode<int> x, LinkedListNode<int> y)
        {
            var resultList = new LinkedList<int>();
            int overflow = 0;

            while (x != null)
            {
                if (y != null)
                {
                    resultList.AddLast((x.Value + y.Value + overflow) % 10);
                    overflow = (x.Value + y.Value + overflow) / 10;
                    x = x.Next;
                    y = y.Next;
                    if (x == null && overflow ==1) resultList.AddLast(overflow); 
                }
                else 
                {
                    resultList.AddLast((x.Value + overflow) % 10);
                    overflow = (x.Value + overflow) / 10;
                    x = x.Next;
                }
            }
            return resultList;
        }
        
    }
}
