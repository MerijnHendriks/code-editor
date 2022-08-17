using System.Collections.Generic;
using Avalonia.Input;

namespace Sake.Utils
{
    public class Shortcuts
    {
        private readonly Dictionary<string, KeyGesture> _keyBindings;

        public Shortcuts()
        {
            _keyBindings = new Dictionary<string, KeyGesture>()
            {
                { "Copy", new KeyGesture(Key.C, KeyModifiers.Control) },
                { "Paste", new KeyGesture(Key.V, KeyModifiers.Control) },
                { "Cut", new KeyGesture(Key.X, KeyModifiers.Control) }
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
