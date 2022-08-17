using System;
using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class StatusText
    {
        private readonly TextEditor _textEditor;
        private readonly TextBlock _statusTextBlock;

        public StatusText(MainWindow mainWindow, ref TextEditor textEditor, ref TextBlock statusTextBlock)
        {
            _statusTextBlock = statusTextBlock;
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
