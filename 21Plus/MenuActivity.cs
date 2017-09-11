using Android.App;
using Android.OS;

namespace _21Plus
{
    [Activity(Label = "_21Plus", MainLauncher = true)]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MainMenu);
        }
    }
}

