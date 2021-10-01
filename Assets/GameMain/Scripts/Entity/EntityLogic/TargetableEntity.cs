using System;
using GameMain.Scripts.Entity.EntityData;
using UnityEngine;

namespace GameMain.Scripts.Entity.EntityLogic
{
    public class TargetableEntity : Entity
    {
        [SerializeField] private TargetableEntityData m_TargetableEntityData = null;
    }
}
