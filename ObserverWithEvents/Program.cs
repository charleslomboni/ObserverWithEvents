using ObserverWithEvents.Interfaces;
using System;

namespace ObserverWithEvents {

    internal class Program {

        private static void Main(string[] args) {
            WithoutEvents();
            WithEvents();

            // Wait some pressed key
            Console.ReadKey();
        }

        /// <summary>
        /// Using observer with events
        /// </summary>
        private static void WithEvents() {
            // Create a instance from the publisher
            IChannelEvents channel = new ChannelEvents();

            // Create os subscribers/observers
            IObserverEvents userCharles = new ObserverEvents(channel);
            IObserverEvents userVictor = new ObserverEvents(channel);
            IObserverEvents userLomboni = new ObserverEvents(channel);
            IObserverEvents userTrindade = new ObserverEvents(channel);
            IObserverEvents moderatorPereira = new ObserverEvents(channel);

            // Sign to the channel
            userCharles.Subscriber();
            userVictor.Subscriber();
            userLomboni.Subscriber();
            userTrindade.Subscriber();
            moderatorPereira.Subscriber();

            // Notify everyone about something new
            channel.OnNotifySubscribers();

            userCharles.Unsubscriber();
            userVictor.Unsubscriber();
            userLomboni.Unsubscriber();
            userTrindade.Unsubscriber();
            moderatorPereira.Unsubscriber();
        }

        /// <summary>
        /// Using observer without events
        /// </summary>
        private static void WithoutEvents() {
            // Create a instance from the publisher
            IChannel channel = new Channel();

            // Create os subscribers/observers
            ISubscriber charles = new User();
            ISubscriber victor = new User();
            ISubscriber lomboni = new User();
            ISubscriber trindade = new User();
            ISubscriber pereira = new Moderator();

            // Sign to the channel
            channel.Subscribe(charles);
            channel.Subscribe(victor);
            channel.Subscribe(lomboni);
            channel.Subscribe(trindade);
            channel.Subscribe(pereira);

            // Notify everyone about something new
            channel.NotifySubscribers();

            // Unsign to the channel
            channel.Unsubscribe(charles);
            channel.Unsubscribe(victor);
            channel.Unsubscribe(lomboni);
            channel.Unsubscribe(trindade);
            channel.Unsubscribe(pereira);
        }
    }
}