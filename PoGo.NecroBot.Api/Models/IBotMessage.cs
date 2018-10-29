using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGo.NecroBot.Api.Models
{
    interface IBotMessage
    {
        void SetText(string);
    }
}
