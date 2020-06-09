// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ShimmerSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel shimlabel { get; set; }

		[Outlet]
		ShimmerSample.ShimmeringView shimmeringView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (shimmeringView != null) {
				shimmeringView.Dispose ();
				shimmeringView = null;
			}

			if (shimlabel != null) {
				shimlabel.Dispose ();
				shimlabel = null;
			}
		}
	}
}
