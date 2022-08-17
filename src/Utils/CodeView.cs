using Avalonia.Controls;
using AvaloniaEdit;
using Sake.Views;

namespace Sake.Utils
{
    public class CodeView
    {
        private readonly TextEditor _textEditor;

        public CodeView(MainWindow mainWindow, ref TextEditor textEditor, Shortcuts shortcuts)
        {
            var contextMenu = new ContextMenu 
            { 
                Items = new MenuItem[] 
                { 
                    new MenuItem { Header = "Copy", InputGesture = shortcuts.Get("Copy") },
                    new MenuItem { Header = "Paste", InputGesture = shortcuts.Get("Paste") },
                    new MenuItem { Header = "Cut", InputGesture = shortcuts.Get("Cut") }
                } 
            };

            _textEditor = textEditor;
            _textEditor.ShowLineNumbers = true;
            _textEditor.ContextMenu = contextMenu;
        }
    }
}
