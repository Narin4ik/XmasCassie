using System;
using Exiled.API.Features;
using XmasCassie;

namespace XmasCassiePlugin
{
    public class Plugin : Plugin<Config, Translation>
    {
        public static Plugin Singleton { get; private set; }

        public override string Name => "XmasCassie";
        public override string Author => "Narin";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 14, 0);

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance += eventHandlers.OnAnnouncingNtfEntrance;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance -= eventHandlers.OnAnnouncingNtfEntrance;
            eventHandlers = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}
