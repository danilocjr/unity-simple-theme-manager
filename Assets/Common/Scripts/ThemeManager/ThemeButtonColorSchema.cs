using UnityEngine;
using UnityEngine.UI;

namespace Theme
{
    [CreateAssetMenu(fileName = "ButtonColorSchema", menuName = "MedRoom/Theme/ButtonColorSchema", order = 2)]
    public class ThemeButtonColorSchema : ScriptableObject
    {
        public Color hover;
        public Color normal;
        public Color click;

        public ColorBlock GetColorBlock()
        {
            ColorBlock colorBlock = new ColorBlock
            {
                normalColor = normal,
                highlightedColor = normal,
                pressedColor = click,
                selectedColor = hover,
                disabledColor = hover,
                colorMultiplier = 1f
            };

            return colorBlock;
        }
    }
}

