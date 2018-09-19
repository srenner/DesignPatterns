using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {

            foreach(var o in _observers)
            {
                o.Update();
            }
        }
    }
}
