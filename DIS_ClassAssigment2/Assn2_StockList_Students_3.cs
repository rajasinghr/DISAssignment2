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
            if (this.IsEmpty())  // Checking if the list is empty
            {
                Console.WriteLine("There are no stocks present");

            }
            StockNode current = head;  // Assigning the head value to current
            while (current != null)
            {
                value = value + (current.StockHolding.CurrentPrice) * (current.StockHolding.Holdings); // Calculating the value
                current = current.Next; // moving to next node
            }
            return value;
        }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
            int similarityIndex = 0;
            StockNode current2 = null;
            if (this.IsEmpty())
            {
                return 0;  // returning result as 0 if list is empty
            }
            if (listToCompare.IsEmpty())
            {
                return 0;  // returning result as 0 if list is empty
            }
            StockNode current1 = head;
            while (current1 != null)
            {
                current2 = listToCompare.head;  // assigning  the header of second list to current 2
                while (current2 != null)
                {
                    if (current1.StockHolding.Name == current2.StockHolding.Name)
                    {
                        similarityIndex = similarityIndex + 1; // comparing the name of stock holdings and incrementing the index if true
                    }
                    current2 = current2.Next;
                }
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
            if (this.IsEmpty()) // Checking if there are stocks present or not
            {
                Console.WriteLine("There are no stocks present");
            }
            else
            {
                StockNode current = head;
                while (current != null)
                {
                    Console.WriteLine(current.StockHolding); // printing the stocks based on client portfolio
                    current = current.Next;
                }
            }
        }
  }
}