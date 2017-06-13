using ObserverWithEvents.Interfaces;
using System;

namespace ObserverWithEvents {

    /// <summary>
    /// The publisher class
    /// </summary>
    public class ChannelEvents : IChannelEvents {

        /// <summary>
        /// Event who is called to notify subscribers
        /// </summary>
        public event Action EventHandler;

        /// <summary>
        /// Notify them about something new
        /// </summary>
        public void OnNotifySubscribers() {
            EventHandler?.Invoke();
        }
    }
}