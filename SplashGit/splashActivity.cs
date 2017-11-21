
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace mySplash
{
    [Activity(Label = "Activity", MainLauncher = true)]
	
	public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Splash);
            //Toast.MakeText(this,"from .cs",ToastLength.Short).Show();

        }

		protected override void OnResume()
		{
			base.OnResume();
			Task startupWork = new Task(() => { SimulateStartup(); });
			startupWork.Start();
		}

		// Simulates background work that happens behind the splash screen
		async void SimulateStartup()
		{
			await Task.Delay(8000); // Simulate a bit of startup work.
			StartActivity(new Intent(Application.Context, typeof(MainActivity)));
		}
    }
}
