namespace ObserverWithEvents.Interfaces {

    public interface IObserverEvents {

        /// <summary>
        /// Add an observer
        /// </summary>
        void Subscriber();

        /// <summary>
        /// Remove an observer
        /// </summary>
        void Unsubscriber();
    }
}