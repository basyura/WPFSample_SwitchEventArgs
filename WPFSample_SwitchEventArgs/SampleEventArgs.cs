using System.Windows;

namespace WPFSample_SwitchEventArgs
{
    public class SampleEventArgs : RoutedEventArgs
    {
        public SampleEventArgs(RoutedEvent ev) : base(ev)
        {
        }
    }
}
