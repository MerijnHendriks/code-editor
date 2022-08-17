using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class CodeView
    {
        private readonly CodeViewTheming _theming;
        private readonly StatusText _statusText;
        private readonly TextEditor _textEditor;

        public CodeView(MainWindow mainWindow, TextEditor textEditor, TextBlock statusTextBlock)
        {
            _textEditor = textEditor;
            _textEditor.ShowLineNumbers = true;
            _statusText = new StatusText(mainWindow, ref _textEditor, ref statusTextBlock);
            _theming = new CodeViewTheming(ref _textEditor);
        }
    }
}
