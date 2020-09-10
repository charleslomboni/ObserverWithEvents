# ObserverWithEvents
Example how to use the observer pattern with events

<strong>Master branch</strong><br />
[![Build status](https://ci.appveyor.com/api/projects/status/nd1731n27xyjrdim/branch/master?svg=true)](https://ci.appveyor.com/project/charleslomboni/observerwithevents/branch/master)

```csharp
/// <summary>
/// Using observer with events
/// </summary>
private static void WithEvents() {
    // Create a instance from the publisher
    IChannelEvents channel = new ChannelEvents();

    // Create os subscribers/observers
    IObserverEvents userCharles0 = new ObserverEvents(channel);
    IObserverEvents userCharles1 = new ObserverEvents(channel);
    IObserverEvents userCharles2 = new ObserverEvents(channel);
    IObserverEvents userCharles3 = new ObserverEvents(channel);
    IObserverEvents moderator = new ObserverEvents(channel);

    // Sign to the channel
    userCharles0.Subscriber();
    userCharles1.Subscriber();
    userCharles2.Subscriber();
    userCharles3.Subscriber();
    moderator.Subscriber();

    // Notify everyone about something new
    channel.OnNotifySubscribers();

    userCharles0.Unsubscriber();
    userCharles1.Unsubscriber();
    userCharles2.Unsubscriber();
    userCharles3.Unsubscriber();
    moderator.Unsubscriber();
}

/// <summary>
/// Using observer without events
/// </summary>
private static void WithoutEvents() {
    // Create a instance from the publisher
    IChannel channel = new Channel();

    // Create os subscribers/observers
    ISubscriber charles0 = new User();
    ISubscriber charles1 = new User();
    ISubscriber charles2 = new User();
    ISubscriber charles3 = new User();
    ISubscriber charles4 = new Moderator();

    // Sign to the channel
    channel.Subscribe(charles0);
    channel.Subscribe(charles1);
    channel.Subscribe(charles2);
    channel.Subscribe(charles3);
    channel.Subscribe(charles4);

    // Notify everyone about something new
    channel.NotifySubscribers();

    // Unsign to the channel
    channel.Unsubscribe(charles0);
    channel.Unsubscribe(charles1);
    channel.Unsubscribe(charles2);
    channel.Unsubscribe(charles3);
    channel.Unsubscribe(charles4);
}
```
