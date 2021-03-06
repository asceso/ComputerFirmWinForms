﻿using System;
using System.Windows.Forms;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MapperCore.MemoryCacheCore;
using InjectingCoreLibrary.MessagingCore.AskBox;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using InjectingCoreLibrary.SettingsCore;
using MainClient.Forms;
using Ninject;
using PermissionsManager;

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
            DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StandardKernel Kernel = new StandardKernel();

            Kernel.Bind<ISettingsInject>().To<SettingsMethods>();
            Kernel.Bind<IMessageInject>().To<MessageInjectForm>();
            Kernel.Bind<IAskInject>().To<AskInjectForm>();
            Kernel.Bind<IMapperInject>().To<MapperMethods>();
            Kernel.Bind<IMemoryInject>().To<MemoryMethods>();
            Kernel.Bind<IPermissionInject>().To<PermissionMethods>();

            ShellForm BootstrapForm = Kernel.Get<ShellForm>();
            Application.Run(BootstrapForm);
        }
    }
}
