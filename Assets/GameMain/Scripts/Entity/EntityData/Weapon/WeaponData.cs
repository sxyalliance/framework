using System;
using UnityEngine;

namespace GameMain.Scripts.Entity.EntityData.Weapon
{
    [Serializable]
    public class WeaponData : EntityData
    {
        [SerializeField] private float m_AttackInterval = 1f;

        [SerializeField] private float m_AttackDamage = 10f;

        public WeaponData(int entityId, int typeId) : base(entityId, typeId)
        {
        }

        public float AttackInterval => m_AttackInterval;

        public float AttackDamage => m_AttackDamage;
    }
}
