using System;
using System.Collections.Generic;

namespace Generic_Collection_Queue
{
    //Queue
    //FIFO
    class Order
    {
        //Properties
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        
        //Constructor
        public Order(int id, int orderQuantity)
        {
            OrderId = id;
            OrderQuantity = orderQuantity;
        }

        //Print order was processed
        public void ProcessOrder()
        {
            //Print the OrderId of the object it's invoked on
            Console.WriteLine($"Order {OrderId} processed!");
        }

        //Return an array of Orders
        public static Order[] RecieveOrdersFromBranch1()
        {
            //Make a new Order array called orders, input data, return array
            Order[] orders = new Order[]
            {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(6,10),
            };
            return orders;
        }
        public static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                       new Order(3,5),
                       new Order(4,4),
                       new Order(5,10),
            };
            return orders;
        }
    }
        class Program
        {

            static void Main(string[] args)
        {
            //Queue<T>---

            //Good for processing requests

            //Big O = O(n) contains/search O(1) add/queue/dequeue

            //Enqueue = add to back of line, Dequeue = return and delete top of stack(first person in line),
            //Peek = Return first in line object but not remove

            //Make queue
            Queue<string> queue = new Queue<string>();

            //Add to queue FIFO
            queue.Enqueue("Command1");
            queue.Enqueue("Command2");
            queue.Enqueue("Command3");

            Console.WriteLine(queue.Peek());

            //Contains
            if (queue.Contains("Command1"))
            {
                Console.WriteLine("Contains \"Command1\" ");
            }

            //Remove and return from queue
            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            //Peek = Return but dont delete
            while (queue.Peek() != "Command3")
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Peek());


            //Create Queue of type Order
            Queue<Order> ordersQueue = new Queue<Order>();

            //For each element inside Order.Rb1, Enqueue into the Queue. 
            //The RecieveOrdersFromBranch creates order objects it uses in x
            //This adds two different orders into the same queue

            foreach (Order x in Order.RecieveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(x);
            }
            foreach (Order x in Order.RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(x);
            }

            //While count is not 0...
            while (ordersQueue.Count > 0)
            {
                //Remove the order at the front of queue
                //and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //Process Order
                currentOrder.ProcessOrder();
            }
        }
    }
}
