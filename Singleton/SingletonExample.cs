// Lazy<Singleton> is the way to go, achieve lazy and thread safe as shown here

namespace Singleton
{
    public static class SingletonExample
    {
        public static async Task Main()
        {
            await Task.Run(() => {
                var singleton = Singleton.Instance;
                singleton.myNumber = 5; 
                Console.WriteLine(singleton.myNumber);
            });
            await Task.Run(() => { Console.WriteLine(Singleton.Instance.myNumber); });

        }
    }
}
