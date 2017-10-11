using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android;

namespace Day6_LinearLayout
{
    [Activity(Label = "Day6_LinearLayout", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
            SetContentView(Resource.Layout.TestFrame);
            //SetContentView(Resource.Layout.LinearHorizontal);
            //SetContentView(Resource.Layout.Relative);
            //SetContentView(Resource.Layout.FrameLayout);
            //SetContentView(Resource.Layout.TableLayout);

    //        Button btnInterest = FindViewById(Resource.Id.btnCalculateInterest) as Button;

    //        btnInterest.Click += delegate {
    //            EditText edtAmount = FindViewById(Resource.Id.editAmount) as EditText;
    //            float amount = float.Parse(edtAmount.Text);

    //            EditText edtRate = FindViewById(Resource.Id.editRateOfInterest) as EditText;
				//float rate = float.Parse(edtRate.Text);

            //    EditText edtYears = FindViewById(Resource.Id.editNoOfYears) as EditText;
            //    float years = float.Parse(edtYears.Text);

            //    float totalInterest = (amount * rate * years) / 100;

            //    Toast.MakeText(this, "Total Interest Interest Amount is " + totalInterest,ToastLength.Long).Show();
            //};
        }
    }
}

