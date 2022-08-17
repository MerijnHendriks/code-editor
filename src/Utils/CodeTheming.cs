using System;
using Avalonia.Media;
using AvaloniaEdit;
using AvaloniaEdit.TextMate;
using TextMateSharp.Grammars;

namespace Sake.Utils
{
    public class CodeTheming : IDisposable
    {
        private readonly RegistryOptions _registryOptions;
        private readonly TextMate.Installation _textMate;
        private readonly int _currentTheme = (int)ThemeName.DarkPlus;

        public CodeTheming(ref TextEditor textEditor)
        {
             // control colors
            textEditor.Background = Brushes.Transparent;
            textEditor.TextArea.Background = Brushes.Transparent;

            // textmate
            _registryOptions = new RegistryOptions((ThemeName)_currentTheme);
            _textMate = textEditor.InstallTextMate(_registryOptions);

            // set default language
            Language defaultLanguage = _registryOptions.GetLanguageByExtension(".cs");
            _textMate.SetGrammar(_registryOptions.GetScopeByLanguageId(defaultLanguage.Id));
        }

        public void Dispose()
        {
            _textMate.Dispose();
        }
    }
}
