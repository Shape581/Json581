using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life;

namespace Json581
{
    public class Main : Plugin
    {
        public Main(IGameAPI api) : base(api) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Json581] - Succès : Initialise !");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
