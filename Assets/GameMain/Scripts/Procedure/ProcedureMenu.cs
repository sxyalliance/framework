using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

namespace GameMain.Scripts.Procedure
{
    public class ProcedureMenu : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Debug("进入菜单流程");

            var eventComponent = GameEntry.GetComponent<EventComponent>();
            var ui = GameEntry.GetComponent<UIComponent>();

            eventComponent.Subscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);
            ui.OpenUIForm("Assets/GameMain/UI/Menu.prefab", "DefaultGroup", this);
        }

        private void OnOpenUIFormSuccess(object sender, GameEventArgs e)
        {
            var ne = (OpenUIFormSuccessEventArgs) e;
            if (ne.UserData != this)
            {
                return;
            }

            Log.Debug("UI打开成功回调");
        }
    }
}