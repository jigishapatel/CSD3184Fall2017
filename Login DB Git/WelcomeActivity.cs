
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

namespace DBLogin
{
    [Activity(Label = "WelcomeActivity")]
    public class WelcomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Welcome);

            // Create your application here
            Toast.MakeText(this, "Welcome", ToastLength.Long).Show();
        }
    }
}
