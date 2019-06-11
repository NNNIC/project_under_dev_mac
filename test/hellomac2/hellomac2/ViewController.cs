using System;

using AppKit;
using Foundation;

namespace hellomac2
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            label_clicked_outlet.StringValue = "Button has not been clicked yet.";
            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void button_clickme_action(NSObject sender)
        {
            this.numberOfTimesClicked++;
            label_clicked_outlet.StringValue = string.Format("The button has been clicked {0} times", this.numberOfTimesClicked);
        }
    }
}
