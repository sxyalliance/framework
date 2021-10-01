using System;
using GameMain.Scripts.Definition.Enum;
using UnityEngine;

namespace GameMain.Scripts.Entity.EntityData
{
    [Serializable]
    public class TargetableEntityData : EntityData
    {
        [SerializeField] private bool m_Targetable = true;

        public TargetableEntityData(int entityId, int typeId) : base(entityId, typeId)
        {
        }

        /// <summary>
        /// 是否可選中。
        /// </summary>
        public bool IsTargetable
        {
            get => m_Targetable;
            set => m_Targetable = value;
        }
    }
}
