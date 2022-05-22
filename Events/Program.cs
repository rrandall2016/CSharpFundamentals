using System;

namespace Events
{
    //Events
    //Events enable a class or object to notify other classes or objects when something of interest occurs.
    //The class that sends (or raises) the event is called the publisher and
    //the classes that receive (or handle) the event are called subscribers.

    //The publisher determines when an event is raised;
    //the subscribers determine what action is taken in response to the event.

    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/
    //https://www.tutorialsteacher.com/csharp/csharp-event

    //An event is a notification sent by an object to signal the occurrence of an action

    //Need to unsubscribe if writing more code
    

    //Publisher
    public class ProcessBusinessLogic
    {
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted(EventArgs.Empty);//raises an event and invokes the delegate, This will call all the event handler methods registered with the ProcessCompleted event.
        }

        protected virtual void OnProcessCompleted(EventArgs e) //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(this, e);
        }

    }
    public class DoorEventArgs : EventArgs
    {
        public bool IsOpen { get; set; }
    }

    public class Door
    {
        public event EventHandler<DoorEventArgs> DoorUsed;
        private bool isOpen = false;

        public Door()
        {
        }

        public void UseDoor()
        {
            isOpen = !isOpen;

            DoorEventArgs args = new DoorEventArgs
            {
                IsOpen = isOpen
            };

            DoorUsed?.Invoke(this, args);
        }


    }

    class Program
    {
        public static void bl_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
        private static void OnDoorUsed(object sender, DoorEventArgs doorArgs)
        {
            Console.WriteLine($"Door open? {doorArgs.IsOpen}");
        }
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();

            //Door
            Door d = new Door();
            d.DoorUsed += OnDoorUsed;

            d.UseDoor();
            d.UseDoor();
            d.UseDoor();
        }
    }
}
