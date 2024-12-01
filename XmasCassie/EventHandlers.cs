using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using PlayerRoles;

namespace XmasCassiePlugin
{
    public class EventHandlers
    {
        public void OnRespawnedTeam(RespawnedTeamEventArgs ev)
        {
            if (ev.Wave.TargetFaction != Faction.FoundationStaff)
            {
                Cassie.Clear();
                Cassie.Message("<b>Звенят бубенцы, звенят бубенцы, звенят всю дорогу.</b><split><b>О, как весело кататься в открытых санях с одной лошадью.</b> <size=0> pitch_1 Xmas_JingleBells . pitch_0.9 Xmas_Epsilon11 NATO_A 6 Xmas_HasEntered 4 Xmas_ScpSubjects </size><split><b>Звенят бубенцы, звенят бубенцы, звенят всю дорогу.</b><split><b>О, как весело кататься в открытых санях с одной лошадью.</b><split><b>Тактическое праздничное подразделение <color=#005EBC>Epsilon-11</color>, позначеный как <color=#005EBC>ALPHA-06</color> вошёл в мастерскую.<split><b>Всем оставшимся эльфам рекомендуется укрыться в ближайшем пряничном домике, пока подразделение не завершит праздничную обработку объекта.</b><split><b>Ожидается повторное сдерживания: <color=red>4</color> вредителей, ненавидящих праздники.</b> pitch_1", false, true, true);
            }
        }
    }
}
