using System;
using System.Windows.Forms;
using CoreClient.InjectingCores.MessagingCore.MessageBox;
using CoreClient.InjectingCores.SettingsCore;
using MainClient.Forms;
using Ninject;

namespace MainClient
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StandardKernel Kernel = new StandardKernel();
            Kernel.Bind<ISettingsInject>().To<SettingsMethods>();
            Kernel.Bind<IMessageInject>().To<MessageInjectForm>();

            AuthForm BootstrapForm = Kernel.Get<AuthForm>();

            Application.Run(BootstrapForm);
        }
    }
}
