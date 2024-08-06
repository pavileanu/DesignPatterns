using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Icon
    {
        public Icon(string type)
        {
            // load icon
        }
    }

    static class IconProvider
    {
        private static Dictionary<string, Icon> _cache = new Dictionary<string, Icon>();

        public static Icon GetIcon(string type)
        {
            if (!_cache.ContainsKey(type))
            {
                _cache[type] = new Icon(type);
            }

            return _cache[type];
        }
    }

    abstract class Button
    {
        public Icon Icon { get; set; }
    }

    class SettingsButton : Button
    {
        public SettingsButton()
        {
            Icon = IconProvider.GetIcon("settings");
        }
    }

    class SolutionWindow
    {
        public SettingsButton settingsButton = new SettingsButton();
    }

    class TerminalWindow
    {
        public SettingsButton settingsButton = new SettingsButton();
    }

    class TestRunnerWindow
    {
        public SettingsButton settingsButton = new SettingsButton();
    }
}
