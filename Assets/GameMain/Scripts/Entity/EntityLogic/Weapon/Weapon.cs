using System;
using GameMain.Scripts.Definition.Constant;
using GameMain.Scripts.Entity.EntityData.Effect;
using GameMain.Scripts.Entity.EntityData.Weapon;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Scripts.Base.GameEntry;

namespace GameMain.Scripts.Entity.EntityLogic.Weapon
{
    public class Weapon : Entity
    {
        [SerializeField] private WeaponData m_WeaponData;

        private bool m_CanDamage = false;
        private float m_NextAttachTime = 0f;

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_WeaponData = userData as WeaponData;
            if (m_WeaponData == null)
            {
                Log.Error("實體數據錯誤：Weapon。");
                return;
            }

            GameEntry.Entity.AttachEntity(this.Entity, 1, "RightHand");
        }

        public void Attack()
        {
            if (Time.time < m_NextAttachTime)
            {
                m_CanDamage = false;
                return;
            }

            m_NextAttachTime = Time.time + m_WeaponData.AttackInterval;
            Log.Info("攻擊！");
            GameEntry.Entity.ShowEffect(new ExplosionData(99, 3)
            {
                Position = transform.position,
            });
            Collider2D[] affectedEntities =
                Physics2D.OverlapCircleAll(transform.position, 5);
            for (int i = 0; i < affectedEntities.Length; i++)
            {
                var affectedEntity = affectedEntities[i].GetComponent<Character>();
                if (affectedEntity == null) continue;
                if (affectedEntity.CompareTag("Enemy"))
                {
                    affectedEntity.ApplyDamage((int) m_WeaponData.AttackDamage);
                }
            }
        }
    }
}
