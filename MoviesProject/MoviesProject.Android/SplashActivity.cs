using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace MoviesProject.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", Icon = "@drawable/ic_logo", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        static readonly string TAG = "x:" + typeof(SplashActivity).Name;
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        //Lunches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startUpWork = new Task(() => { SimulateStartUp(); });
            startUpWork.Start();
        }

        //The Simulates background work that happen behind the splash screen
        private async void SimulateStartUp()
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            await Task.Delay(100);//Simulate a bit of startup work.
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}