using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PopupMenuDemo
{
    [Activity (Label = "PopupMenuDemo", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            SetContentView (Resource.Layout.Main);

            Button showPopupMenu = FindViewById<Button> (Resource.Id.popupButton);

            showPopupMenu.Click += delegate {
                //Toast.MakeText(this, "hello", ToastLength.Long).Show();

                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) => {
                    Toast.MakeText(this, e1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();
                };

                menu.Show();

                /*PopupMenu menu = new PopupMenu (this, showPopupMenu);
                menu.Inflate (Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, a1) =>
                {
                    Toast.MakeText(this, a1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();
                };
               
                menu.Show();*/
            };

            /*
            showPopupMenu.Click += (s, arg) => {
                
                PopupMenu menu = new PopupMenu (this, showPopupMenu);
                
                // with Android 3 need to use MenuInfater to inflate the menu
                //menu.MenuInflater.Inflate (Resource.Menu.popup_menu, menu.Menu);
                
                // with Android 4 Inflate can be called directly on the menu
                menu.Inflate (Resource.Menu.popup_menu);
                
                menu.MenuItemClick += (s1, arg1) => {
                    Console.WriteLine ("{0} selected", arg1.Item.TitleFormatted);
                    String selection = arg1.Item.TitleFormatted.ToString();

                    Toast.MakeText(this,selection,ToastLength.Long).Show();
                };
                
                // Android 4 now has the DismissEvent
                menu.DismissEvent += (s2, arg2) => {
                    Console.WriteLine ("menu dismissed"); 
                };
                
                menu.Show ();
            };
            */
        }
    }
}