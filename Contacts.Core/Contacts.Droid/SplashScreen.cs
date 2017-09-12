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
using MvvmCross.Droid.Views;

namespace Contacts.Droid
{
    [Activity(Label = "ApplicationName",
        MainLauncher = true)]
    public class SplashScreen: MvxSplashScreenActivity
    {
        //replace LayoutName with an actual layout
        //public SplashScreen() : base(Resource.Layout.LayoutName)
        //{ }
    }
}