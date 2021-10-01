using UnityEngine;

namespace GameMain.Scripts.Definition.Constant
{
    public static partial class Constant
    {
        /// <summary>
        /// 層優先級。
        /// </summary>
        public static class Layer
        {
            public const string DefaultLayerName = "Default";
            public static readonly int DefaultLayerId = LayerMask.NameToLayer(DefaultLayerName);

            public const string EnvironmentLayerName = "Environment";
            public static readonly int EnvironmentLayerId = LayerMask.NameToLayer(EnvironmentLayerName);

            public const string UILayerName = "UI";
            public static readonly int UILayerId = LayerMask.NameToLayer(UILayerName);

            public const string CharacterLayerName = "Character";
            public static readonly int CharacterLayerId = LayerMask.NameToLayer(CharacterLayerName);

            public const string PlayerLayerName = "Player";
            public static readonly int PlayerLayerId = LayerMask.NameToLayer(PlayerLayerName);
        }
    }
}
