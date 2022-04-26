using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudyObserverPatternLibrary
{
    public class NotificationService:INotificationService
    {
        List<INotificationObserver> observerList = new List<INotificationObserver>();
        int count = 1;
        public void AddSubscriber(INotificationObserver obs)
        {
            observerList.Add(obs);
            Console.WriteLine(count + " List of subscribers");
            count++;
            foreach (var i in observerList)
                Console.WriteLine(i.Name);
            NotifySubscriber();

        }
        public void NotifySubscriber()
        {
            foreach (var i in observerList)
                i.OnServerDown();
        }
        public void RemoveSubscriber(INotificationObserver obs)
        {
            observerList.Remove(obs);
            Console.WriteLine("List Of Subscribers are:");
            foreach (var i in observerList)
                Console.WriteLine(i.Name);
        }
    }
}
