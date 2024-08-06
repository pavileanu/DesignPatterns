// FLYWEIGHT este folositor pentru memorie, daca avem 1000 de obiecte in memorie diferite, mai bine avem unul singur 
// care sa fie referenced in 1000 de locuri. (OPTIMIZARE)
// Pentru Implementare, folosim un fel de singleton array + un factory care sa ne dea acealsi element,
// ideea este ca putem avea mai multe obiecte pe care sa facem referenced nu doar unul.
// DECI, ACEASI REFERINTA AVEM + SETARI DIFERITE pentru fiecare obiect ( PUTEM FOLOSI UN DECORATOR PENTRU ASTA)

namespace Flyweight
{
    public static class FlyweightExample
    {
        public static void Main()
        {
            SolutionWindow sw = new SolutionWindow();
            TerminalWindow tw = new TerminalWindow();

            Console.WriteLine(sw.settingsButton.Icon);
            Console.WriteLine(tw.settingsButton.Icon);

            // VOM AVEA ACELASI ICON IN MEMORIE, doar setarile din settingsButton pot fi diferite, 
            // astfel am opitmizat memoria
        }
    }
}
