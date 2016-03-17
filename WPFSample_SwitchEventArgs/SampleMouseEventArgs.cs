using System.Windows.Input;

namespace WPFSample_SwitchEventArgs
{
    public class SampleMouseEventArgs : MouseButtonEventArgs
    {
        public SampleMouseEventArgs(MouseDevice mouse, int timestamp, MouseButton button) : base(mouse, timestamp, button)
        {
        }
    }
}
