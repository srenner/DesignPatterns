using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class SiteSubscriber : Observer
    {
        public string _subscriberName { get; set; }
        public string MailingListState { get; set; }

        public SiteSubscriber(string name)
        {
            _subscriberName = name;
        }

        public override void Update()
        {
            Console.WriteLine("Observer {0} received the new state {1}", this._subscriberName, this.MailingListState);
        }
    }
}
