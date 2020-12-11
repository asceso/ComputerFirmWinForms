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
                if (item is BaseStyledButton button)
                {
                    //colors
                    button.BackColor = button.Enabled ? FormBrushes.ButtonBackgroundColor : FormBrushes.ButtonDisabledBackgroundColor;
                    button.BackColorAdditional = FormBrushes.ButtonBackgroundAdditionalColor;
                    button.ForeColor = FormBrushes.ButtonForegroundColor;
                    button.EnabledChanged += BaseButtonEnabledChanged;

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

        public static void SetDefaultColor(this BaseStyledButton button)
        {
            //colors
            button.BackColor = button.Enabled ? FormBrushes.ButtonBackgroundColor : FormBrushes.ButtonDisabledBackgroundColor;
            button.BackColorAdditional = FormBrushes.ButtonBackgroundAdditionalColor;
            button.ForeColor = FormBrushes.ButtonForegroundColor;
            button.EnabledChanged += BaseButtonEnabledChanged;

            //bools
            button.RoundingEnable = FormBrushes.ButtonDefaultRounded;
            button.UseDownPressEffectOnClick = FormBrushes.ButtonDefaultUseDownPressEffectOnClick;
            button.UseRippleEffect = FormBrushes.ButtonDefaultUseRippleEffect;
            button.UseZoomEffectOnHover = FormBrushes.ButtonDefaultUseZoomEffectOnHover;

            //int
            button.Rounding = FormBrushes.ButtonDefaultRounding;
        }

        private static void BaseButtonEnabledChanged(object sender, System.EventArgs e)
        {
            if (sender is BaseStyledButton button)
            {
                button.BackColor = button.Enabled ? FormBrushes.ButtonBackgroundColor : FormBrushes.ButtonDisabledBackgroundColor;
            }
        }
    }
}
