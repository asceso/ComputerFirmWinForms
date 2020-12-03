using System.Windows.Forms;
using CoreClient.StyleExtensions.Controls;

namespace CoreClient.StyleExtensions
{
    public static class ControlElementsBrusher
    {
        public static void SetDefaultColorForChildren(this Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is BaseStyledButton baseButton)
                {
                    //colors
                    baseButton.BackColor = FormBrushes.ButtonBackgroundColor;
                    baseButton.BackColorAdditional = FormBrushes.ButtonBackgroundAdditionalColor;
                    baseButton.ForeColor = FormBrushes.ButtonForegroundColor;

                    //bools
                    baseButton.RoundingEnable = FormBrushes.ButtonDefaultRounded;
                    baseButton.UseDownPressEffectOnClick = FormBrushes.ButtonDefaultUseDownPressEffectOnClick;
                    baseButton.UseRippleEffect = FormBrushes.ButtonDefaultUseRippleEffect;
                    baseButton.UseZoomEffectOnHover = FormBrushes.ButtonDefaultUseZoomEffectOnHover;

                    //int
                    baseButton.Rounding = FormBrushes.ButtonDefaultRounding;
                }
            }
        }
        public static void SetDefaultColor(this BaseStyledButton button)
        {
            //colors
            button.BackColor = FormBrushes.ButtonBackgroundColor;
            button.BackColorAdditional = FormBrushes.ButtonBackgroundAdditionalColor;
            button.ForeColor = FormBrushes.ButtonForegroundColor;

            //bools
            button.RoundingEnable = FormBrushes.ButtonDefaultRounded;
            button.UseDownPressEffectOnClick = FormBrushes.ButtonDefaultUseDownPressEffectOnClick;
            button.UseRippleEffect = FormBrushes.ButtonDefaultUseRippleEffect;
            button.UseZoomEffectOnHover = FormBrushes.ButtonDefaultUseZoomEffectOnHover;

            //int
            button.Rounding = FormBrushes.ButtonDefaultRounding;
        }
    }
}
