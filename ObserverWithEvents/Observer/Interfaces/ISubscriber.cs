namespace ObserverWithEvents.Observer.Interfaces {

    /// <summary>
    /// Interface for all classes that need be a subscriber to action
    /// </summary>
    public interface ISubscriber {

        /// <summary>
        /// Method who will be called to notify subscribers
        /// </summary>
        void Notify();
    }
}