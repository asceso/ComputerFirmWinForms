using System.Drawing;

namespace CoreClient.StyleExtensions
{
    public static class FormBrushes
    {
        //Font
        public static readonly Font DefaultRegularFont = new Font("Fira Code", 9.749999F, FontStyle.Regular);
        public static readonly Font DefaultBoldFont = new Font("Fira Code", 9.749999F, FontStyle.Bold);

        //Window
        public static readonly Color WindowBackGroundColor = Color.FromArgb(0xDF, 0xE1, 0xEE);
        public static readonly Color WindowForegroundColor = Color.FromArgb(0x12, 0x14, 0x1d);

        //Button
        public static readonly Color ButtonBackgroundColor = Color.FromArgb(0x3b, 0x59, 0x98);
        public static readonly Color ButtonBackgroundAdditionalColor = Color.FromArgb(0x3b, 0x59, 0x98);
        public static readonly Color ButtonForegroundColor = Color.FromArgb(0xDF, 0xE1, 0xEE);
        public static readonly Color ButtonDisabledBackgroundColor = Color.FromArgb(0x6c, 0x69, 0x60);

        public static readonly bool ButtonDefaultUseRippleEffect = true;
        public static readonly bool ButtonDefaultUseDownPressEffectOnClick = false;
        public static readonly bool ButtonDefaultUseZoomEffectOnHover = false;

        public static readonly bool ButtonDefaultRounded = true;
        public static readonly int ButtonDefaultRounding = 100;

        public const string ContactNumberMask = "0-(000)-000-00-00";
    }
}
