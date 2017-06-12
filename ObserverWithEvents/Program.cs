using ObserverWithEvents.Observer;
using ObserverWithEvents.Subject;
using System;

namespace ObserverWithEvents {

    internal class Program {

        private static void Main(string[] args) {
            // Create a instance from the publisher
            var channel = new Channel();

            // Create os subscribers/observers
            var charles = new User();
            var victor = new User();
            var lomboni = new User();
            var trindade = new User();
            var pereira = new Moderator();

            // Sign to the channel
            channel.Subscribe(charles);
            channel.Subscribe(victor);
            channel.Subscribe(lomboni);
            channel.Subscribe(trindade);
            channel.Subscribe(pereira);

            // Notify everyone about something new
            channel.NotifySubscribers();

            // Wait some pressed key
            Console.ReadKey();
        }
    }
}