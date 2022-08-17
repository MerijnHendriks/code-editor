using System;
using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class StatusText
    {
        private TextEditor _textEditor;
        private TextBlock _statusTextBlock;

        public StatusText(MainWindow mainWindow, ref TextEditor textEditor)
        {
            _statusTextBlock = mainWindow.Find<TextBlock>("StatusText");
            _textEditor = textEditor;
            _textEditor.TextArea.Caret.PositionChanged += Caret_PositionChanged;
        }

        private void Caret_PositionChanged(object sender, EventArgs e)
        {
            _statusTextBlock.Text = string.Format("Ln {0}, Col {1}", 
                _textEditor.TextArea.Caret.Line,
                _textEditor.TextArea.Caret.Column);
        }
    }
}
