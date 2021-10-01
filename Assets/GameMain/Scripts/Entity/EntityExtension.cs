using System;
using GameMain.Scripts.Definition.Constant;
using GameMain.Scripts.Entity.EntityData;
using GameMain.Scripts.Entity.EntityData.Effect;
using GameMain.Scripts.Entity.EntityData.Weapon;
using GameMain.Scripts.Entity.EntityLogic;
using GameMain.Scripts.Entity.EntityLogic.Effect;
using GameMain.Scripts.Entity.EntityLogic.Weapon;
using UnityGameFramework.Runtime;

namespace GameMain.Scripts.Entity
{
    public static class EntityExtension
    {
        public static void HideEntity(this EntityComponent entityComponent, EntityLogic.Entity entity)
        {
            entityComponent.HideEntity(entity.Entity);
        }

        public static void ShowHero(this EntityComponent entityComponent, HeroData data)
        {
            entityComponent.ShowEntity(typeof(Hero), "Assets/GameMain/Entities/SuperHero.prefab", "Character",
                Constant.AssetPriority.AircraftAsset, data);
        }

        public static void ShowEvil(this EntityComponent entityComponent, EvilData data)
        {
            entityComponent.ShowEntity(typeof(Evil), "Assets/GameMain/Entities/Evil.prefab", "Character",
                Constant.AssetPriority.AircraftAsset, data);
        }

        public static void ShowWeapon(this EntityComponent entityComponent, WeaponData data)
        {
            entityComponent.ShowEntity(typeof(Weapon), "Assets/GameMain/Entities/Weapon.prefab", "WeaponTool",
                Constant.AssetPriority.AircraftAsset, data);
        }

        public static void ShowEffect(this EntityComponent entityComponent, ExplosionData data)
        {
            entityComponent.ShowEntity(typeof(Explosion), "Assets/GameMain/Entities/Explosion.prefab", "Effect",
                Constant.AssetPriority.AircraftAsset, data);
        }

        private static void ShowEntity(this EntityComponent entityComponent, Type logicType, string assetName,
            string entityGroup, int priority, EntityData.EntityData data)
        {
            if (data == null)
            {
                Log.Warning("Data is invalid.");
                return;
            }

            // IDataTable<DREntity> dtEntity = GameEntry.DataTable.GetDataRowataTable<DREntity>();
            // DREntity drEntity = dtEntity.GetDataRow(data.TypeId);
            // if (drEntity == null)
            // {
            //     Log.Warning("Can not load entity id '{0}' from data table.", data.TypeId.ToString());
            //     return;
            // }

            entityComponent.ShowEntity(data.Id, logicType, assetName, entityGroup, priority, data);
        }
    }
}
