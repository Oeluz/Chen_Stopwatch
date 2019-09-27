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

namespace Chen_Stopwatch
{
    [Activity(Label = "ListActivity")]
    public class ListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ActionBar.Hide();
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}