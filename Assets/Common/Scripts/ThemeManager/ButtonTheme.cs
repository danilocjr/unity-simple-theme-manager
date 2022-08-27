using UnityEngine;
using UnityEngine.UI;

namespace Theme
{
    public class ButtonTheme : MonoBehaviour
    {
        [SerializeField] private ButtonColors _buttonColor;
        [SerializeField] private Button _button;

        private void Awake()
        {
            ThemeManager.OnInit += ThemeManager_OnInit;              
        }

        private void ThemeManager_OnInit(ThemeManager themeManager)
        {
            _button.colors = themeManager.GetButtonColor(_buttonColor);
        }
    }
}

