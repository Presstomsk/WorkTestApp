using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTestApp
{
    public static class SecondApp
    {
        public static LinkedList<int> SumTwoLists(LinkedList<int> firstNumber, LinkedList<int> secondNumber)
        {
            var resultList = new LinkedList<int>();
            var item1 = firstNumber.First;
            var item2 = secondNumber.First;
            int overflow = 0;
            if (firstNumber.Count > secondNumber.Count)
            {
                while (item1 != null) //TODO
                {
                    if (item2 != null)
                    {
                        resultList.AddLast((item1.Value + item2.Value + overflow) % 10) ;
                        overflow = (item1.Value + item2.Value+ overflow) / 10;
                        item1 = item1.Next;
                        item2 = item2.Next;
                    }
                    else
                    {
                        resultList.AddLast(item1.Value+overflow);                        
                        item1 = item1.Next;                        
                    }
                }
                return resultList;
            }
            else
            {
                while (item2 != null)
                {
                    if (item1 != null)
                    {
                        resultList.AddLast((item1.Value + item2.Value + overflow) % 10);
                        overflow = (item1.Value + item2.Value+ overflow) / 10;
                        item1 = item1.Next;
                        item2 = item2.Next;
                    }
                    else
                    {
                        resultList.AddLast(item2.Value+overflow);
                        item2 = item2.Next;
                    }
                }
                return resultList;
            }
            
        }
        
    }
}
