using Cinemachine;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameMain.Scripts.DataTable;
using GameMain.Scripts.Entity;
using GameMain.Scripts.Entity.EntityData;
using GameMain.Scripts.Entity.EntityData.Weapon;
using GameMain.Scripts.Entity.EntityLogic;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Scripts.Base.GameEntry;
using UnityEngine;

namespace GameMain.Scripts.Procedure
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("初始！");

            // var CMCmp = GetComponent<CinemachineVirtualCamera>();

            Log.Debug("訂閱事件！");
            // GameEntry.Event.Subscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            Log.Debug("加載數據表！");
            // GameEntry.DataTable.LoadDataTable("Hero", "Assets/GameMain/DataTables/Heroes.txt", this);
            Log.Debug("加載實體！");

            GameEntry.Entity.ShowHero(new HeroData(1, 1));
            GameEntry.Entity.ShowEvil(new EvilData(2, 1));
            GameEntry.Event.Subscribe(ShowEntitySuccessEventArgs.EventId, OnShowEntitySuccess);

            // ChangeState<ProcedureMenu>(procedureOwner);
        }

        private static void OnShowEntitySuccess(object sender, GameEventArgs e)
        {
            Log.Info("等我睇下跟住邊個先");
            var ne = (ShowEntitySuccessEventArgs) e;
            var player = ne.Entity;
            if (!player.CompareTag("Player"))
            {
                return;
            }

            var camera = GameObject.Find("CM VCAM");
            if (camera != null)
            {
                camera.GetComponent<CinemachineVirtualCamera>().Follow = player.transform;
            }
            else
            {
                Log.Warning("");
            }
        }

        private static void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        {
            var dtScene = GameEntry.DataTable.GetDataTable<DRHero>();

            // 获得所有行
            var drHeroes = dtScene.GetAllDataRows();
            Log.Debug("drHeros:" + drHeroes.Length);
            // 根据行号获得某一行
            var drScene = dtScene.GetDataRow(1); // 或直接使用 dtScene[1]
            if (drScene != null)
            {
                // 此行存在，可以获取内容了
                string name = drScene.Name;
                int atk = drScene.Attack;
                Log.Debug("name:" + name + ", atk:" + atk);
            }
            else
            {
                // 此行不存在
            }

            // 获得满足条件的所有行
            // var drScenesWithCondition = dtScene.GetAllDataRows(x => x.Id > 0);

            // 获得满足条件的第一行
            DRHero drSceneWithCondition = dtScene.GetDataRow(x => x.Name == "mutou");
        }
    }
}
