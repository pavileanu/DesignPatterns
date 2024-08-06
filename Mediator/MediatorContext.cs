using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        public void Interaction();
    }

    public class Mediator : IMediator
    {
        public Piece piece;
        public Part part;
        public Thing thing;

        public Mediator()
        {
            // setup components	
        }

        public void Interaction()
        {

        }
    }

    public class Piece
    {
        IMediator mediator;
        public Piece(IMediator mediator) => this.mediator = mediator;

        public void Invoke()
        {
            mediator.Interaction();
        }
    }

    public class Part
    {
        IMediator mediator;
        public Part(IMediator mediator) => this.mediator = mediator;

    }

    public class Thing
    {
        IMediator mediator;
        public Thing(IMediator mediator) => this.mediator = mediator;

    }
}
