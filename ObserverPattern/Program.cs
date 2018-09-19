using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mailingList = new MailingList();

            mailingList.Subscribe(new SiteSubscriber("Abby"));
            mailingList.Subscribe(new SiteSubscriber("Beto"));
            mailingList.Subscribe(new SiteSubscriber("Carl"));

            mailingList.State = "New issue is available";
            mailingList.Notify();

            Console.ReadKey();
        }
    }
}
