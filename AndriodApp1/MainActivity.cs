using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace AndriodApp1
{
    [Activity(Label = "AndriodApp1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        // This will be my list of names
        private List<string> myList;
        private ListView myListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SampleList);
            /*ListView needs to reference it's ID from the resource folder
             * This is how you tell the compiler what list view you're referring to */
            myListView = FindViewById<ListView>(Resource.Id.POIListView);
            //instantiate and add to my list
            myList = new List<string>();
            myList.Add("King");
            myList.Add("Jessica");
            myList.Add("Canaan");
            myList.Add("Starleigh");
            myList.Add("Khaleesi");
            myList.Add("Jeremiah");
            myList.Add("Jaylen");
            //Now you need an adapter to plug your list into
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myList);
            //Attach your adapter to the ListView's adapter 
            myListView.Adapter=adapter;       
           
            // Get our button from the layout resource,
            // and attach an event to it
            //  Button button = FindViewById<Button>(Resource.Id.MyButton);
            //  button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

        }
    }
}

