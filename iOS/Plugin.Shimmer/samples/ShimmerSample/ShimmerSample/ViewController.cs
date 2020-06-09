using Foundation;
using System;
using UIKit;

using Plugin.Shimmer;

namespace ShimmerSample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            shimmeringView.Shimmering = true;
            shimmeringView.ShimmeringSpeed = 300;

            shimmeringView.ShimmeringBeginFadeDuration = 0.3;
            shimmeringView.ShimmeringOpacity = 0.3f;
            shimmeringView.ContentView = shimlabel;
             //ShimmeringView view 
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}