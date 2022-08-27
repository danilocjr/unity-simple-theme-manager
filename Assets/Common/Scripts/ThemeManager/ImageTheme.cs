using UnityEngine;
using UnityEngine.UI;

namespace Theme
{
    public class ImageTheme : MonoBehaviour
    {
        [SerializeField] private ImageColors _imageColor;
        [SerializeField] private Image _image;

        private void Awake()
        {
            ThemeManager.OnInit += ThemeManager_OnInit;              
        }

        private void ThemeManager_OnInit(ThemeManager themeManager)
        {
            _image.color = themeManager.GetImageThemedColor(_imageColor);
        }
    }
}

