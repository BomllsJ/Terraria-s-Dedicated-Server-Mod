﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria_Server.Events
{
    public abstract class BaseMessageEvent : Event
    {
        public string Message { get; set; }
    }
}
