using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class SiteSubscriber : Observer
    {
        public string _subscriberName;
        public MailingList _subject;


        public SiteSubscriber(MailingList subject, string name)
        {
            _subscriberName = name;
            _subject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("Observer {0} received the new state {1}", _subscriberName, _subject.State);
        }
    }
}
