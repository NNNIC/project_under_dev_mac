// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace hellomac2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField label_clicked_outlet { get; set; }

        [Action ("button_clickme_action:")]
        partial void button_clickme_action (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (label_clicked_outlet != null) {
                label_clicked_outlet.Dispose ();
                label_clicked_outlet = null;
            }
        }
    }
}
