using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using Sake.Utils;

namespace Sake.Views
{
    public partial class MainWindow : Window
    {
        private readonly CodeView _codeView;

        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);

            var textEditor = this.FindControl<TextEditor>("Editor");
            var statusTextBlock = this.Find<TextBlock>("StatusText");
            _codeView = new CodeView(this, textEditor, statusTextBlock);
        }
    }
}
