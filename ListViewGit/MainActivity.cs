using Android;
using Android.App;
using Android.Widget;
using Android.OS;
using System;



namespace myListView
{
    [Activity(Label = "myListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
		static readonly string[] countries = new String[] {
			"India","Canada","Japan","Jordan","China","Hong Kong","Malawi","Malaysia","Maldives","Singapore","Slovakia"
			};
		ListView lstCountryList;
		ArrayAdapter<string> countryDataAdapter;

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //lstCountryList = FindViewById<ListView>(Resource.Id.countryList);

			lstCountryList = FindViewById(Resource.Id.countryList) as ListView;

            countryDataAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, countries);
            lstCountryList.Adapter = countryDataAdapter;


            lstCountryList.ItemClick += listView_ItemClick;

        }

		void listView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			//Get our item from the list adapter
            var item = this.countryDataAdapter.GetItem(e.Position);

			//Make a toast with the item name just to show it was clicked
			Toast.MakeText(this, item + " Clicked!", ToastLength.Short).Show();
		}
		
    }
}

