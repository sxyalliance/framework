using GameMain.Scripts.Entity.EntityData;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace GameMain.Scripts.Entity.EntityLogic
{
    public class Evil : Character
    {
        [SerializeField] private EvilData m_EvilData;

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_EvilData = userData as EvilData;
            if (m_EvilData == null)
            {
                Log.Error("實體數據錯誤：Evil。");
            }

            Log.Debug("實體已顯示");
        }
    }
}
