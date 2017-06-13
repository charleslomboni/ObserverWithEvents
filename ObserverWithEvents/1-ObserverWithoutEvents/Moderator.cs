using ObserverWithEvents.Interfaces;
using System;

namespace ObserverWithEvents {

    /// <summary>
    /// Moderator is a subscriber from the channel
    /// </summary>
    public class Moderator : ISubscriber {

        /// <summary>
        /// Method called when there is a new notify
        /// </summary>
        public void Notify() {
            Console.WriteLine("Moderator, there are some videos that need to be reviewed...");
        }
    }
}