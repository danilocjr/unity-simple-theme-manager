using TMPro;
using UnityEngine;

namespace Theme
{
    public class TextTheme : MonoBehaviour
    {
        [SerializeField] private TextColors _textColor;
        [SerializeField] private Fonts _textFont;
        [SerializeField] private TMP_Text _text;
        
        private void Awake()
        {
            ThemeManager.OnInit += ThemeManager_OnInit;
        }

        private void ThemeManager_OnInit(ThemeManager themeManager)
        {
            _text.color = themeManager.GetTextThemedColor(_textColor);
            _text.font = themeManager.GetTextThemedFont(_textFont);
        }
    }
}

