﻿namespace Ai
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Konwersje
    {
        public static CommandType GetActionType(DirectionType at)
        {
            return (CommandType)Enum.Parse(typeof(CommandType), at.ToString());
        }
    }
}
