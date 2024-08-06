// Proxy pattern - Nu dorim sa cream un obiect, ca atare intr-o clasa proxy, tinem acest obiect, cand avem nevoie de obiect
// vom initiliza proxy, care va creea obiectul respectiv. MOTIVUL ESTE PENTRU A NU INCARCA MEMORIA SAU A AVEA OBIECTE DE CARE
// NU AVEM NEVOIE. De exemplu, un image nu-l cream, avem o clasa proxy_image, care ia setarile de image si creeaza image in functie
// de dimenisuni de exemplu.
// ARATA CODUL CA DECORATOR, DAR NU E, NU MODIFICAM OBIECTUL, DOAR IL RETINEM NEMODIFICANDUL, FOLOSINDUL LA NEVOIE

// UNDE IL FOLOSIM, daca avem la compile time ceva idei cum ar fi obiectul, mai bine avem un proxy care sa se asigure
// ca obiectul pe care il folosim este autentificat sau lazy sau fallback sau retry policy sau ceva specific
// DACA CEVA SE INTAMPLA/MODIFICA SCHIMBAM PROXY si nu OBIECTUL :)

namespace Proxy
{
    public static class ProxyExample
    {
        public static void Main()
        {
            ISettings settings = new RemoteSettings("db:my-db");
            ISettings lazySettings = new LazySettings("db:lazy-db");

            Console.WriteLine(settings.getConfig());
            Console.WriteLine(lazySettings.getConfig());
        }
    }
}
