using System;
using GameMain.Scripts.Definition.Enum;

namespace GameMain.Scripts.Entity.EntityData
{
    [Serializable]
    public class EvilData : CharacterData
    {
        public EvilData(int entityId, int typeId) : base(entityId, typeId, FactionType.Unknown)
        {
        }

        public override int MaxHP => 100;
    }
}
