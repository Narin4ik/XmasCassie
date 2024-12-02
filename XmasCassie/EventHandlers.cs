using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;

namespace XmasCassiePlugin
{
    public class EventHandlers
    {
        public void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
        {
            ev.IsAllowed = false;

            string designatedcassie = Plugin.Singleton.Translation.DesignatedSassie.Replace("{unitChar}", ev.UnitName[0].ToString()).Replace("{unitNumber}", ev.UnitNumber.ToString());
            Cassie.Message(Plugin.Singleton.Translation.Announcement.Replace("{designatedcassie}", designatedcassie).Replace("{designatedtext}", ev.UnitName + '-' + ev.UnitNumber).Replace("{scpleft}", ev.ScpsLeft.ToString()), false, true, true);
        }
    }
}