using GameMain.Scripts.Base;

namespace GameMain.Scripts.Entity.EntityLogic.Effect
{
    public class Explosion : Entity
    {
        private float m_ElapseSeconds = 0f;

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_ElapseSeconds = 0f;
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);

            m_ElapseSeconds += elapseSeconds;
            if (m_ElapseSeconds >= 3f)
            {
                GameEntry.Entity.HideEntity(this);
            }
        }
    }
}
