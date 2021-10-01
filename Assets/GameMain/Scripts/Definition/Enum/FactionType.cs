namespace GameMain.Scripts.Definition.Enum
{
    /// <summary>
    /// 陣營類型。
    /// </summary>
    /// <remarks>有需要可以用bitwise operator支持多陣營。</remarks>
    public enum FactionType : byte
    {
        Unknown = 0,

        /// <summary>
        /// 天主教陣營。
        /// </summary>
        Catholic,

        /// <summary>
        /// 晨星教陣營。
        /// </summary>
        MorningStar,

        /// <summary>
        /// 劫掠者陣營。
        /// </summary>
        Looter,

        /// <summary>
        /// 商旅陣營。
        /// </summary>
        Merchant,

        /// <summary>
        /// 平民陣營。
        /// </summary>
        Civilian
    }
}
