using System;
using System.Threading;
using MaxPlayle.DiscordNetBotTemplate.Source.Util;

namespace MaxPlayle.DiscordNetBotTemplate.Source
{
    internal class EntryPoint
    {

        static void Main()
        {
            while (true)
            {
                Log.Info("info");
                Thread.Sleep(2000);
                Log.Warn("warn");
                Thread.Sleep(2000);
                Log.Error("error");
            }
        }
        
    }
}