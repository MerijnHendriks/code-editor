using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class CodeView
    {
        private readonly CodeViewTheming _theming;
        private readonly TextEditor _textEditor;

        public CodeView(MainWindow mainWindow, TextEditor textEditor)
        {
            _textEditor = textEditor;
            _textEditor.ShowLineNumbers = true;
            _theming = new CodeViewTheming(ref _textEditor);
        }
    }
}
