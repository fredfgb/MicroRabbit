using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Commands.Command;
        void Publish<T>(T @event) where T : Events.Event;
        void Subscribe<T, TH>() where T : Events.Event where TH : IEventHandler<T>; 
    }
}
