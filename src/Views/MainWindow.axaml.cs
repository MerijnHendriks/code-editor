using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using Sake.Utils;

namespace Sake.Views
{
    public partial class MainWindow : Window
    {
        private readonly CodeView _codeView;
        private readonly StatusBar _statusBar;

        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);

            var textEditor = this.FindControl<TextEditor>("Editor");
            _codeView = new CodeView(this, textEditor);

            var statusBar = this.Find<TextBlock>("StatusText");
            _statusBar = new StatusBar(this, ref textEditor, ref statusBar);
        }
    }
}
