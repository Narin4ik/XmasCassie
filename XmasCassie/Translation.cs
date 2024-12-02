using Exiled.API.Interfaces;
namespace XmasCassie
{
    public sealed class Translation : ITranslation
    {
        public string Announcement { get; set; } = "<b>Звенят бубенцы, звенят бубенцы, звенят всю дорогу.</b><split><b>О, как весело кататься в открытых санях с одной лошадью.</b> <size=0> pitch_1 Xmas_JingleBells . pitch_0.9 Xmas_Epsilon11 {designatedcassie} Xmas_HasEntered {scpleft} Xmas_ScpSubjects </size><split><b>Звенят бубенцы, звенят бубенцы, звенят всю дорогу.</b><split><b>О, как весело кататься в открытых санях с одной лошадью.</b><split><b>Тактическое праздничное подразделение <color=#005EBC>Epsilon-11</color>, позначенный как <color=#005EBC>{designatedtext}</color> вошёл в мастерскую.<split><b>Всем оставшимся эльфам рекомендуется укрыться в ближайшем пряничном домике, пока подразделение не завершит праздничную обработку объекта.</b><split><b>Ожидается повторное сдерживания: <color=red>{scpleft}</color> вредителей, ненавидящих праздники.</b> pitch_1";
        public string DesignatedSassie { get; set; } = "NATO_{unitChar} {unitNumber}";
    }
}
