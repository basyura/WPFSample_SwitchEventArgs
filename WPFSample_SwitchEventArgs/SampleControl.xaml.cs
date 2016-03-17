using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFSample_SwitchEventArgs
{
    /// <summary>
    /// SampleControl.xaml の相互作用ロジック
    /// </summary>
    public partial class SampleControl : UserControl
    {
        /// <summary></summary>
        public static RoutedEvent SampleChangedEvent = EventManager.RegisterRoutedEvent(
                                                    "SampleChanged", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(SampleControl)); 
        /// <summary>
        /// 
        /// </summary>
        public SampleControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        public event RoutedEventHandler SampleChanged
        {
            add    { AddHandler(SampleChangedEvent,    value); }
            remove { RemoveHandler(SampleChangedEvent, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchEvent(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RaiseEvent(new SampleMouseEventArgs(Mouse.PrimaryDevice , 0, MouseButton.Left)
            {
                RoutedEvent = SampleControl.MouseLeftButtonDownEvent,
                Source      = this,
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaiseSampleEvent(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RaiseEvent(new SampleEventArgs(SampleControl.SampleChangedEvent));
        }
    }
}
