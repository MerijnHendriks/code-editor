using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Input;
using AvaloniaEdit;

namespace Sake.Utils
{
    public class CodeViewShortcuts
    {
        private readonly Dictionary<string, KeyGesture> _keyBindings;

        public CodeViewShortcuts(ref TextEditor textEditor)
        {
            _keyBindings = new Dictionary<string, KeyGesture>();

            // bindings
            _keyBindings.Add("Copy", new KeyGesture(Key.C, KeyModifiers.Control));
            _keyBindings.Add("Paste", new KeyGesture(Key.V, KeyModifiers.Control));
            _keyBindings.Add("Cut", new KeyGesture(Key.X, KeyModifiers.Control));

            // context menu
            textEditor.ContextMenu = new ContextMenu 
            { 
                Items = new List<MenuItem> 
                { 
                    new MenuItem { Header = "Copy", InputGesture = Get("Copy") },
                    new MenuItem { Header = "Paste", InputGesture = Get("Paste") },
                    new MenuItem { Header = "Cut", InputGesture = Get("Cut") }
                } 
            };
        }

        public void Add(string name, KeyGesture keys)
        {
            _keyBindings.Add(name, keys);
        }

        public KeyGesture Get(string name)
        {
            return _keyBindings[name];
        }
    }
}
