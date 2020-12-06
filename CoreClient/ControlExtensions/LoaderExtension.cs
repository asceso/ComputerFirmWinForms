using System;
using System.Windows.Forms;
using CoreClient.StyleExtensions;
using DevExpress.XtraSplashScreen;

namespace CoreClient.ControlExtensions
{
    public static class LoaderExtension
    {
        public static IOverlaySplashScreenHandle ShowLoader(this Control handledControl)
        {
            OverlayWindowOptions options = new OverlayWindowOptions()
            {
                AnimationType = WaitAnimationType.Line,
                LineAnimationParameters = new LineAnimationParams(5, 15, 5),
                ForeColor = FormBrushes.ButtonBackgroundColor,
                BackColor = FormBrushes.WindowForegroundColor,
                FadeIn = true,
                FadeOut = true,
                Opacity = 0.35,
                StartupDelay = 55,
            };
            Func<IOverlaySplashScreenHandle> func = () => SplashScreenManager.ShowOverlayForm(handledControl, options);
            return (IOverlaySplashScreenHandle)handledControl.Invoke(func);
        }

        public static void HideLoader(this Control handledControl, IOverlaySplashScreenHandle overlayHandle)
            => handledControl.Invoke((MethodInvoker)delegate { SplashScreenManager.CloseOverlayForm(overlayHandle); });
    }
}
