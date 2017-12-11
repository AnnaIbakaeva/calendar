using Android.App;
using Android.Widget;
using Android.OS;

namespace Calendar.Core.Droid
{
    [Activity(Label = "Calendar")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += Button_Click;
        }

        void Button_Click(object sender, System.EventArgs e)
        {

        }
    }
}

