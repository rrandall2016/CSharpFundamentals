using System;
using System.Collections.Generic;

namespace LinkedListMergeTwoSortedListsLC
{
    class Program
    {
        public LinkedList<int> MergeTwoLists(LinkedList<int> l1, LinkedList<int> l2)
        {
            LinkedList<int> test = new();
            //Iterate until end of list
            while (l1 != null && l2 != null)
            {
                if (l1.First.Value < l2.First.Value)
                {
                    //Assign the tail as the next node
                    tail.next = l1;
                    //Assign the current node
                    l1 = l1.next;
                }
                else
                {
                    //Repeat above but with l2
                    tail.next = l2;
                    l2 = l2.next;
                }

                tail = tail.next;
            }

            tail.next = l1 == null ? l2 : l1;

            return head.next;
        }

        static void Main(string[] args)
        {

            int[] testing3 = new int[] {1, 2, 3, 4};
            LinkedList<int> testing2 = new(testing3);            
            int[] testing4 = new int[] {1, 2, 3, 4};
            LinkedList<int> testing5 = new(testing4);

            foreach(var item in testing2)
            {
                Console.WriteLine(item);
            }
           


            

        }
    }
}
