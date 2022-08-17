using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using Sake.Utils;

namespace Sake.Views
{
    public partial class MainWindow : Window
    {
        private readonly CodeView _codeView;
        private readonly CodeTheming _theming;
        private readonly Shortcuts _shortcuts;
        private readonly StatusBar _statusBar;

        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);

            var textEditor = this.FindControl<TextEditor>("Editor");
            _shortcuts = new Shortcuts();
            _codeView = new CodeView(this, ref textEditor, _shortcuts);
            _theming = new CodeTheming(ref textEditor);

            var statusBar = this.Find<TextBlock>("StatusText");
            _statusBar = new StatusBar(this, ref textEditor, ref statusBar);
        }
    }
}
