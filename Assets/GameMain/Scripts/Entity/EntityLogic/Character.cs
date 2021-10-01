using GameMain.Scripts.Definition.Constant;
using GameMain.Scripts.Entity.EntityData;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Scripts.Base.GameEntry;

namespace GameMain.Scripts.Entity.EntityLogic
{
    public class Character : Entity
    {
        [SerializeField] private CharacterData m_CharacterData;

        public bool IsDead => m_CharacterData.HP <= 0;

        public void ApplyDamage(int damage)
        {
            m_CharacterData.HP -= damage;
            if (IsDead)
            {
                OnDead();
            }
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            gameObject.SetLayerRecursively(Constant.Layer.CharacterLayerId);
        }

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_CharacterData = userData as CharacterData;
            if (m_CharacterData == null)
            {
                Log.Error("實體數據錯誤：Character。");
            }
        }

        protected virtual void OnDead()
        {
            GameEntry.Entity.HideEntity(this.Entity);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var entity = other.gameObject.GetComponent<Entity>();
            if (entity == null)
            {
                return;
            }
        }
    }
}
