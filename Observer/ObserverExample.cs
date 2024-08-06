// Observer pattern is the same as in angular or other languages
// We do observe something and we do react.


// In C# we do have events that have similar idea, but it is just for 1 element, EventHandler reacts on action,
// and we do modify the component that is having the emitter ( Example UI Form will react to a Button INSIDE THE UI, WHEN WE
// CLICK

// We also have a library special for Observerable and Observer which does serve similiar to this example.
// NEED A IMPLEMENTATION WITH C# library to get pro


namespace Observer
{
    public static class ObserverExample
    {
        public static void Main()
        {
            var alarm = new Alarm();
            alarm.AddWatcher(new FireStation());
            alarm.AddWatcher(new PoliceStation());
            alarm.AddWatcher(new HospitalStation());
            alarm.Notify();
        }
    }
}
