using System;
using GameMain.Scripts.Definition.Enum;
using UnityEngine;

namespace GameMain.Scripts.Entity.EntityData
{
    [Serializable]
    public abstract class CharacterData : EntityData
    {
        [SerializeField] private FactionType m_Faction;

        [SerializeField] private int m_HP = 0;

        [SerializeField] private float m_MeleeSpeed = 2f;

        protected CharacterData(int entityId, int typeId, FactionType faction) : base(entityId, typeId)
        {
            m_Faction = faction;
        }

        /// <summary>
        /// 所屬陣營。
        /// </summary>
        public FactionType Faction => m_Faction;

        /// <summary>
        /// 當前生命。
        /// </summary>
        public int HP
        {
            get => m_HP;
            set => m_HP = value;
        }

        /// <summary>
        /// 近戰攻擊速度。
        /// </summary>
        public float MeleeSpeed => m_MeleeSpeed;

        /// <summary>
        /// 最大生命。
        /// </summary>
        public abstract int MaxHP { get; }

        /// <summary>
        /// 生命百分比。
        /// </summary>
        public float HPPercentage => MaxHP > 0 ? (float) HP / MaxHP : 0f;
    }
}
