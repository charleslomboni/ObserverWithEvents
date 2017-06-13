namespace ObserverWithEvents.Interfaces {

    public interface IChannel {

        /// <summary>
        /// Make the subscription
        /// </summary>
        /// <param name="subscriber"></param>
        void Subscribe(ISubscriber subscriber);

        /// <summary>
        /// Leave a subscription
        /// </summary>
        /// <param name="subscriber"></param>
        void Unsubscribe(ISubscriber subscriber);

        /// <summary>
        /// For all subscribers, notify them about something new
        /// </summary>
        void NotifySubscribers();
    }
}