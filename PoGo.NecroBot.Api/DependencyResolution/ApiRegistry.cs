using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGo.NecroBot.Api.Models;

namespace PoGo.NecroBot.Api.DependencyResolution
{
    public class ApiRegistry
    {
        For<IBotCommunicate>().Use<BotCommunicate>().Singleton();
    }
}
