using finalProject;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace finalProject
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            this.InitializeComponent();
            page01Button.Tag = typeof(OrderPage);
            page02Button.Tag = typeof(MaterialManagement);
            page03Button.Tag = typeof(EventScheduling);
            page04Button.Tag = typeof(Statistics);
            page05Button.Tag = typeof(TableManager);
            page06Button.Tag = typeof(EmployeeManagement);
            page07Button.Tag = typeof(VIP);
        }
        private void pageButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var type = button.Tag as Type;
            var screen = new ShellWindow(type);
            screen.Activate();

            this.Close();
        }
    }
}
