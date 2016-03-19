using System;
using System.Windows;
using System.Windows.Input;

namespace WPFSample_SwitchEventArgs
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SampleMouseEventArgs ev = e as SampleMouseEventArgs;
            MessageBox.Show(string.Format("Raised MouseLeftButtonDown{0}{1}", Environment.NewLine, ev));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleControl_SampleChanged(object sender, RoutedEventArgs e)
        {
            SampleEventArgs ev = e as SampleEventArgs;
            MessageBox.Show(string.Format("Raised SampleChanged{0}{1}", Environment.NewLine, ev));
        }
    }
}
