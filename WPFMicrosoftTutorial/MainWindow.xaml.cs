using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMicrosoftTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // The convenience property below allows us to access the mainwindowcontext object that is set as the datacontext of the main group
        private MainWindowDataContext DC => (MainWindowDataContext)DataContext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void onSubmitClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {DC.userName}!");
        }
    }
}
