// E simplu, Chain-ul este in functie de ce poate face fiecare obiect in workflow, de exemplu, daca un employee
// lucreaza si nu stie ce sa faca merge la manager, apoi daca nici manager-ul nu stie, va ajunge la CEO companiei.
// Astfel avem chain Employee.Do() => Manager.Do() => CEO.Do();
// IN ASP.NET MIDDLEWARE PATTREN LUCREAZA ASA, INTAI AVEM CORS, APOI STATIC FILES, APOI AUTHENTICATION, APOI ROUTING,
// este un chain de comenzi.


namespace ChainOfReponsability
{
    public static class ChainOfReponsabilityExample
    {
        public static void Main()
        {
            var ide = new IDE(null);
            var editor = new CodeEditor(ide);
            var codeSelection = new CodeSelection(editor);

            codeSelection.HandleKey("Ctrl+F");
            codeSelection.HandleKey("Alt+F4");
        }
    }
}
