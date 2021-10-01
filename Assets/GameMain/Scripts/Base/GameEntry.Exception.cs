using System;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace GameMain.Scripts.Base
{
    public partial class GameEntry : MonoBehaviour
    {
        private void OnEnable()
        {
            Application.logMessageReceived += OnExceptionReceived;
            Log.Info("異常處理就緒。");
        }

        private static void OnExceptionReceived(string condition, string stackTrace, LogType type)
        {
            if (type == LogType.Exception)
            {
                Log.Error($"捕獲到異常：{condition}{Environment.NewLine}詳細堆棧：{stackTrace}");
            }
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= OnExceptionReceived;
            Log.Info("異常處理終止。");
        }
    }
}
