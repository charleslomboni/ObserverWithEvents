using ObserverWithEvents.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverWithEvents {

    /// <summary>
    /// The publisher class
    /// </summary>
    public class Channel : IChannel {

        /// <summary>
        /// List of observers
        /// </summary>
        private readonly IList<ISubscriber> _subscribersList = new List<ISubscriber>();

        /// <summary>
        /// Make the subscription
        /// </summary>
        /// <param name="subscriber"></param>
        public void Subscribe(ISubscriber subscriber) {
            _subscribersList.Add(subscriber);
            Console.WriteLine("Subscribe event...");
        }

        /// <summary>
        /// Leave a subscription
        /// </summary>
        /// <param name="subscriber"></param>
        public void Unsubscribe(ISubscriber subscriber) {
            _subscribersList.Remove(subscriber);
            Console.WriteLine("Unsubscribe event...");
        }

        /// <summary>
        /// For all subscribers, notify them about something new
        /// </summary>
        public void NotifySubscribers() {
            foreach (var subscriber in _subscribersList) {
                subscriber.Notify();
            }
        }
    }
}