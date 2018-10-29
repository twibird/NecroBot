using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGo.NecroBot.Api.Models
{
    public class BotMessage : IBotMessage
    {
        private string _text;

        public void SetText(string text)
        {
            _text = text;
        }
    }
}
