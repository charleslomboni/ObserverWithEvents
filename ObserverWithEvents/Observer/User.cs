using ObserverWithEvents.Observer.Interfaces;
using System;

namespace ObserverWithEvents.Observer {

    /// <summary>
    /// User is a subscriber from the channel
    /// </summary>
    public class User : ISubscriber {

        /// <summary>
        /// Method called when there is a new notify
        /// </summary>
        public void Notify() {
            Console.WriteLine("User was notified...");
        }
    }
}