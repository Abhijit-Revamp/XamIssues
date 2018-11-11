using AppKit;
using CoreGraphics;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace XamIssues.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        readonly NSWindow _window;

        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var frameSz = NSScreen.MainScreen.Frame;

            var rect = new CGRect(500, 1000, 500, 500);
            _window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            _window.SetFrame(frameSz, true, true);
            _window.BackgroundColor = NSColor.Black;

            _window.Title = "Xamarin Issues";
        }
        
        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        public override NSWindow MainWindow
        {
            get { return _window; }
        }

        [Export("applicationShouldTerminateAfterLastWindowClosed:")]
        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
        {
            return true;
        }
    }
}
