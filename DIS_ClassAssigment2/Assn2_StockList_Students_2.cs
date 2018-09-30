using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
            StockList resultList = new StockList();
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            else { 
            StockNode current1 = this.head;

            
            while (current1 != null)
            {
                resultList.AddStock(current1.StockHolding);
                current1 = current1.Next;
            }
            }
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            else { 
            StockNode current2 = listToMerge.head;
            
            while (current2 != null)
            {
                resultList.AddStock(current2.StockHolding);
                current2 = current2.Next;
            }
            }
            return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
            Stock mostShareStock = null;
            StockNode current = this.head;
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            mostShareStock = current.StockHolding;
            current = current.Next;
            while (current != null)
            {
                if (current.StockHolding.Holdings> mostShareStock.Holdings )
                {

                    mostShareStock = current.StockHolding;
                }
                current = current.Next;
            }
            Console.WriteLine(mostShareStock);
            return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");

            }
            
            StockNode current = this.head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            return length;
    }
  }
}