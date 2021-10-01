using System;
using GameFramework.Event;
using GameMain.Scripts.Definition.Constant;
using GameMain.Scripts.Entity.EntityData;
using GameMain.Scripts.Entity.EntityData.Weapon;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Scripts.Base.GameEntry;

namespace GameMain.Scripts.Entity.EntityLogic
{
    public class Hero : Character
    {
        [SerializeField] private HeroData m_HeroData;

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_HeroData = userData as HeroData;
            if (m_HeroData == null)
            {
                Log.Error("實體數據錯誤：Hero。");
                return;
            }

            Log.Debug("實體已顯示");

            GameEntry.Entity.ShowWeapon(new WeaponData(5, 1));
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
            var horizontalInput = Input.GetAxis("Horizontal");
            Move(horizontalInput * 5);
            if (Input.GetMouseButtonDown(0))
            {
                Attack(realElapseSeconds);
            }
        }

        private void Move(float distance)
        {
            var rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = new Vector2(distance * 5, rigidbody.velocity.y);
        }

        private void Attack(float realElapseSeconds)
        {
            var weapon = GetComponentInChildren<Weapon.Weapon>();
            weapon.Attack();
        }
    }
}
