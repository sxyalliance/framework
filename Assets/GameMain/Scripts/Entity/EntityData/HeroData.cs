using System;
using GameMain.Scripts.Definition.Enum;

namespace GameMain.Scripts.Entity.EntityData
{
    [Serializable]
    public class HeroData : CharacterData
    {
        public HeroData(int entityId, int typeId) : base(entityId, typeId, FactionType.Unknown)
        {
        }

        public override int MaxHP => 100;
    }
}
