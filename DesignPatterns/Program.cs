//Design Patterns
/* 1) Facotry  2) Builder3) Singleton
4) Adapter  5) Decorator  6) Proxy   7) Bridge ???  8) Flyweight ???
9) Chain of responsibility   10) Mediator    11) Observer    12) Strategy    13) Visitor    14) Temaplate*/
using Factory;
using Decorator;
using Singleton;
using Adapter;
using Proxy;
using Bridge;


int designPattern = 7;
switch (designPattern) 
{
    case 1:
        FactoryExample.Main();
        break;
    case 2:
        BuilderExample.Main();
        break;
    case 3:
        await SingletonExample.Main();
        break;
    case 4:
        await AdapterExample.Main();
        break;
    case 5:
        DecoratorExample.Main();
        break;
    case 6:
        ProxyExample.Main();
        break;
    case 7:
        BridgeExample.Main();
        break;
}

