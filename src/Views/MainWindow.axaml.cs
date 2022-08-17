using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Sake.Utils;

namespace Sake.Views
{
    public partial class MainWindow : Window
    {
        private CodeView _codeView;

        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            _codeView = new CodeView(this);
        }
    }
}
