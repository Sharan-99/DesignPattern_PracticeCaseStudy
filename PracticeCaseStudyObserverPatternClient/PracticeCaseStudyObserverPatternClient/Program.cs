using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeCaseStudyObserverPatternLibrary;

namespace PracticeCaseStudyObserverPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationObserver steve = new SteveObserver();
            steve.Name = "Sharan";
            INotificationObserver john = new JohnObserver();
            john.Name = "Gokul";
            NotificationService ns = new NotificationService();
            ns.AddSubscriber(steve);
            ns.AddSubscriber(john);
            ns.RemoveSubscriber(steve);
            Console.ReadKey();

        }
    }
}
