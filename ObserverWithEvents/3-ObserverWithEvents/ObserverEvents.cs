using ObserverWithEvents.Interfaces;
using System;

namespace ObserverWithEvents {

    internal class ObserverEvents : IObserverEvents {

        /// <summary>
        /// Subject class {Publisher}
        /// </summary>
        private readonly IChannelEvents _channel;

        public ObserverEvents(IChannelEvents channel) {
            _channel = channel;
        }

        /// <summary>
        /// Add an observer
        /// </summary>
        public void Subscriber() {
            _channel.EventHandler += Notify;
            Console.WriteLine("Subscribe event...");
        }

        /// <summary>
        /// Remove an observer
        /// </summary>
        public void Unsubscriber() {
            _channel.EventHandler -= Notify;
            Console.WriteLine("Unsubscribe event...");
        }

        /// <summary>
        /// Method called when there is a new notify
        /// </summary>
        private static void Notify() {
            Console.WriteLine("This observer was notified about new video...");
        }
    }
}