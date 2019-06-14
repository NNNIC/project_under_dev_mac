using System;
using System.IO;
using AppKit;
using Foundation;

namespace net0614
{
    public partial class ViewController : NSViewController
    {
        NSTimer m_timer;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            image_outlet.Image = new NSImage("/Users/nnnic/Projects/unity-tutorial.png");

            var i = 0;
            m_timer = NSTimer.CreateRepeatingScheduledTimer(1f, (tm) => { Console.WriteLine("!" + i); i++; });

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
    }
}
