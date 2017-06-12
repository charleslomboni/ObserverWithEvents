using ObserverWithEvents.Observer.Interfaces;
using System.Collections.Generic;

namespace ObserverWithEvents.Subject {

    /// <summary>
    /// The publisher class
    /// </summary>
    public class Channel {

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
        }

        /// <summary>
        /// Leave a subscription
        /// </summary>
        /// <param name="subscriber"></param>
        public void Unsubscribe(ISubscriber subscriber) {
            _subscribersList.Remove(subscriber);
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