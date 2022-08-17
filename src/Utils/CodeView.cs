using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class CodeView
    {
        private CodeViewTheming _theming;
        private StatusText _statusText;
        private TextEditor _textEditor;

        public CodeView(MainWindow mainWindow)
        {
            _textEditor = mainWindow.FindControl<TextEditor>("Editor");
            _textEditor.ShowLineNumbers = true;
            _statusText = new StatusText(mainWindow, ref _textEditor);
            _theming = new CodeViewTheming(ref _textEditor);
        }
    }
}
