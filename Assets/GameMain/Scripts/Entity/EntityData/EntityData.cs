using System;
using UnityEngine;

namespace GameMain.Scripts.Entity.EntityData
{
    [Serializable]
    public abstract class EntityData
    {
        [SerializeField] private int m_ID = 0;

        [SerializeField] private int m_TypeId = 0;

        [SerializeField] private Vector3 m_Position = Vector3.zero;

        [SerializeField] private Quaternion m_Rotation = Quaternion.identity;

        public EntityData(int entityId, int typeId)
        {
            m_ID = entityId;
            this.m_TypeId = typeId;
        }

        /// <summary>
        /// 實體編號。
        /// </summary>
        public int Id => m_ID;

        /// <summary>
        /// 實體類型編號。
        /// </summary>
        public int TypeId => m_TypeId;

        /// <summary>
        /// 實體位置。
        /// </summary>
        public Vector3 Position
        {
            get => m_Position;
            set => m_Position = value;
        }

        /// <summary>
        /// 實體朝向。
        /// </summary>
        public Quaternion Rotation
        {
            get => m_Rotation;
            set => m_Rotation = value;
        }
    }
}
