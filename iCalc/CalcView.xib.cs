
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iCalc
{
	public partial class CalcView : UIViewController
	{
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public CalcView (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public CalcView (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public CalcView () : base("CalcView", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}
		
		#endregion
		
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			textBox1.Text = "1";
			textBox2.Text = "2";
		}
		
		partial void buttonPressed (UIButton sender)
		{
			var value1 = Convert.ToInt32(textBox1.Text);	
			var value2 = Convert.ToInt32(textBox2.Text);
			var ourResult = value1 + value2;
			
			resultLabel.Text = ourResult.ToString();
		}


	}
}
