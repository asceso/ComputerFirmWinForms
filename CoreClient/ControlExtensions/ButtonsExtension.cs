using CoreClient.StyleExtensions.Controls;

namespace CoreClient.ControlExtensions
{
    public static class ButtonsExtension
    {
        public static void SetVisibleByPermissionStatus(this BaseStyledButton button, bool permissionStatus)
            => button.Visible = permissionStatus;
    }
}
