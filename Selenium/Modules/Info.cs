﻿using System.Threading.Tasks;
using Discord.Commands;
// ReSharper disable UnusedMember.Global

namespace Selenium.Modules
{
    public class Info : SeleniumModuleBase
    {
        public Config Config { get; set; }

        [Command("ping"), Alias("latency"), Summary("Returns latency to Discord.")]
        public Task Ping()
            => Reply(_("info.ping", Constants.ClockEmoji, Context.Client.Latency));

        [Command("version"), Summary("Gets the snapshot version of Selenium.")]
        public Task Version()
            => Reply(_("info.snapshot", Constants.InfoEmoji, Config.Snapshot));
    }
}
