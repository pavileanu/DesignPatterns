//Design Patterns
/* 1) Facotry  2) Builder3) Singleton
4) Adapter  5) Decorator  6) Proxy   7) Bridge ???  8) Flyweight ???
9) Chain of responsibility   10) Mediator    11) Observer    12) Strategy    13) Visitor    14) Temaplate*/
using Factory;
using Decorator;


int designPattern = 5;
switch (designPattern) 
{
    case 1:
        FactoryExample.Main();
        break;
    case 2:
        BuilderExample.Main();
        break;
    case 5:
        DecoratorExample.Main();
        break;
}

