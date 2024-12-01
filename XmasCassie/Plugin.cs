using System;
using Exiled.API.Features;

namespace XmasCassiePlugin
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton { get; private set; }

        public override string Name => "XmasCassie";
        public override string Author => "Narin";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Server.RespawnedTeam += eventHandlers.OnRespawnedTeam;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RespawnedTeam -= eventHandlers.OnRespawnedTeam;
            eventHandlers = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}
