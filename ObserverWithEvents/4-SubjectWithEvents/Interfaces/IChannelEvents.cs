using System;

namespace ObserverWithEvents.Interfaces {

    public interface IChannelEvents {

        /// <summary>
        /// Event who is called to notify subscribers
        /// </summary>
        event Action EventHandler;

        /// <summary>
        /// Notify them about something new
        /// </summary>
        void OnNotifySubscribers();
    }
}