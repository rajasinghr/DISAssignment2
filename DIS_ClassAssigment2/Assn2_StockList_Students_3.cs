using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;

      // write your implementation here

      return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
            int similarityIndex = 0;
            StockNode current1 = head;
            StockNode current2 = listToCompare.head;
            while (current1 != null)
            {
                while (current2 != null)
                {
                    if (current1.StockHolding.Name == current2.StockHolding.Name)
                    {
                        similarityIndex = similarityIndex + 1;
                    }
                    current2 = current2.Next;
                }
                current2 = listToCompare.head;
                current1 = current1.Next;
            }
            return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {
            // write your implementation here
            // write your implementation here


            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            else
            {
                StockNode current = this.head;
                while (current != null)
                {
                    Console.WriteLine(current.StockHolding);
                    current = current.Next;
                }
            }
        }
  }
}