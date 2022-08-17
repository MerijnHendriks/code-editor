using Avalonia.Controls;
using Sake.Utils;

namespace Sake.Views
{
    public partial class MainWindow : Window
    {
        private CodeView _codeView;

        public MainWindow()
        {
            InitializeComponent();
            _codeView = new CodeView(this);
        }
    }
}
