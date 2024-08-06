using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Thing<T> where T : class, IStrategy, new()
    {
        public void Do() => new T().Do();
    }

    public interface IStrategy
    {
        void Do();
    }

    public class A : IStrategy
    {
        public void Do() => Console.WriteLine("A");
    }

    public class B : IStrategy
    {
        public void Do() => Console.WriteLine("B");
    }
}
