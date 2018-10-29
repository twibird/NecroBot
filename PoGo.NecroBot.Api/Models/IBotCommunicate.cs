using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGo.NecroBot.Api.Models
{
    interface IBotCommunicate
    {
        void Send(string command); // TODO: create a command object to pass instead
    }
}
