using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server; 
using PlayerRoles;
using Respawning;

namespace XmasCassiePlugin
{
    public class EventHandlers
    {
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam != SpawnableTeamType.NineTailedFox)
                return;

            foreach (Player player in ev.Players)
            {
                player.UnitName;
            }

            string unitName = ev.Player.UnitName ?? "UNKNOWN";
            string unitCassie = unitName.Replace("-", "_");

            int scpCount = Player.List.Count(player => player.IsScp && player.Role != RoleTypeId.Scp0492);

            Log.Debug($"Respawning MTF Unit: {unitName} (Cassie: {unitCassie}), SCPs Left: {scpCount}");

            string cassieMessage = Plugin.Singleton.Config.CustomCassieMessage
                .Replace("{designatedtext}", unitName)
                .Replace("{designatedcassie}", unitCassie)
                .Replace("{scpleft}", scpCount.ToString());

            ev.IsAllowed = false;
            Cassie.Clear();
            Cassie.Message(cassieMessage, false, true, true);
        }
    }
}
