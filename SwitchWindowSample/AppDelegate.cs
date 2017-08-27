using AppKit;
using Foundation;

namespace SwitchWindowSample
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // 1. ファイル→新しいファイル→ストーリーボードでSub.storyboardを作成
            // 2. 作成したStoryboardをIBで開いてWindowControllerを追加
            // 3. IBでWindowControllerを選択→IdentityInspectorを選択→StoryboardIDにMainWindowと入力

            // StoryBoardを呼び出し
            var storyboard = NSStoryboard.FromName("Sub", null);

            // StoryBoardからViewControllerを呼び出し
            var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;

            // 表示
            controller.ShowWindow(this);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
