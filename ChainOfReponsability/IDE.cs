using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsability
{

    interface IKeyHandler
    {
        void HandleKey(string key);
    }

    class IDE : IKeyHandler
    {
        IKeyHandler _handler;

        public IDE(IKeyHandler handler) => _handler = handler;

        public void HandleKey(string key)
        {
            if (key == "Ctrl+F")
            {
                Console.WriteLine("Full Search");
            }
            else if (key == "Alt+F4")
            {
                Console.WriteLine("Close Application?");
            }
            else
            {
                _handler?.HandleKey(key);
            }
        }
    }

    class CodeEditor : IKeyHandler
    {
        IKeyHandler _handler;

        public CodeEditor(IKeyHandler handler) => _handler = handler;

        public void HandleKey(string key)
        {
            if (key == "Ctrl+F")
            {
                Console.WriteLine("Local Search");
            }
            else
            {
                _handler?.HandleKey(key);
            }
        }
    }

    class CodeSelection : IKeyHandler
    {
        IKeyHandler _handler;

        public CodeSelection(IKeyHandler handler) => _handler = handler;

        public void HandleKey(string key)
        {
            if (key == "Ctrl+F")
            {
                Console.WriteLine("Selection Search");
            }
            else
            {
                _handler?.HandleKey(key);
            }
        }
    }
}
