using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform;
using MvvmCross.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart(new AppStart());
        }
    }
}
