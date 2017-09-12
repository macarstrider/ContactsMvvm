using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Contacts.Core;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace Contacts.Droid
{
    public class Setup : MvxAndroidSetup
    {

        public Setup(Context context) : base(context)
        {
            //this is called first on AppLaunching on Android
        }

        protected override IMvxApplication CreateApp()
        {
            //link the Core App class here to initialize
            return new App();
        }

        // Override this if your application is using fragments, because default ViewPresenter
        // does not work with fratments
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxFragmentPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentPresenter);
            return mvxFragmentPresenter;
        }
    }
}