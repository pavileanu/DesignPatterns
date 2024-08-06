// ADAPTER or WRAPPER is the thing I have done my whole life, 3rd party library, creating a new client with methods
// Avoid static classes and methods, create classes instead with interfaces that can be injected with Dependency injections
// Can Apply to be a singleton when injecting depending on the case

// There is a second aproach to inherit, per example here HttpClient and create new functions by inherting and overriding methods,
// very rigid aproach as we depend on the structure of parent class

namespace Adapter
{
    public static class AdapterExample
    {
        public async static Task Main()
        {
            var httpClient = new APIClient(new HttpClient());

            var stringHeader = await httpClient.GetHttpHeader("http://google.com");

            Console.WriteLine(stringHeader);
        }
    }
}
