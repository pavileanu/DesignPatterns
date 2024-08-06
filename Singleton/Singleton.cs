
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public int myNumber { get; set; }

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton()
        {
        }
    }
    
}
