using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mailingList = new MailingList();

            mailingList.Subscribe(new SiteSubscriber(mailingList, "Abby"));
            mailingList.Subscribe(new SiteSubscriber(mailingList, "Beto"));
            mailingList.Subscribe(new SiteSubscriber(mailingList, "Carl"));

            mailingList.State = "New issue is available";
            mailingList.Notify();

            mailingList.State = "We are shutting down on 12/31";
            mailingList.Notify();



            Console.ReadKey();
        }
    }
}
