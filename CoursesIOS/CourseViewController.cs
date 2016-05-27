using System;

using UIKit;

namespace CoursesIOS
{
	public partial class CourseViewController : UIViewController
	{
		public CourseViewController () : base ("CourseViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void buttonNext_TouchUpInside (UIButton sender)
		{
			labelTitle.Text = "Next Clicked";
		}

		partial void buttonPrev_TouchUpInside (UIButton sender)
		{
			labelTitle.Text = "Prev Clicked";
		}
	}
}


