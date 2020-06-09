using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace ShimmerSample
{
    [Activity(MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            var shimmerLayout = FindViewById<Plugin.ShimmerLayout.ShimmerFrameLayout>(Resource.Id.shimmer_layout);
            shimmerLayout.StartShimmer();

             
        }
    }
}
