#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Plasma_Rev
{
    public static class Program
    {
        public static Main game;

        [STAThread]
        static void Main()
        {
            using (game = new Main())
                game.Run();
        }
    }
}
