using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace DateTimePicker
{
    [Activity(Label = "DateTimePicker", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        TextView timeDisplay;
        Button timeSelectButton;
        TextView dateDisplay;
        Button dateSelectButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            timeDisplay = FindViewById<TextView>(Resource.Id.time_display);
            timeSelectButton = FindViewById<Button>(Resource.Id.time_select_button);
            timeSelectButton.Click += TimeSelectOnClick;

            dateDisplay = FindViewById<TextView>(Resource.Id.date_display);
            dateSelectButton = FindViewById<Button>(Resource.Id.date_select_button);
            dateSelectButton.Click += DateSelectOnClick;
        }

        private void DateSelectOnClick(object sender, EventArgs e)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(
                delegate (DateTime time)
                {
                    dateDisplay.Text = time.ToLongDateString();
                });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }

        // Handler for the button click
        void TimeSelectOnClick(object sender, EventArgs eventArgs)
        {
            // Instantiate a TimePickerFragment (defined below) 
            TimePickerFragment frag = TimePickerFragment.NewInstance(
                delegate (DateTime time)
                {
                    timeDisplay.Text = time.ToShortTimeString();
                });

            // Launch the TimePicker dialog fragment (defined below):
            frag.Show(FragmentManager, TimePickerFragment.TAG);
        }
    }
}

