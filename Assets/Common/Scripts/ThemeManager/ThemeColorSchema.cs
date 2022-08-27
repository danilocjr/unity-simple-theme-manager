using TMPro;
using UnityEngine;

namespace Theme
{
    [CreateAssetMenu(fileName = "ThemeColorSchema", menuName = "MedRoom/Theme/ColorSchema", order = 1)]
    public class ThemeColorSchema : ScriptableObject
    {
        [Header("Images")]
        public Color imageSolidBg;
        public Color formSolidBg;

        [Header("Text")]
        public Color textPrimary;
        public Color textSecondary;
        public Color textButton;
        public Color textError;

        [Header("TMP Font Asset")]
        public TMP_FontAsset fontRegular;

        [Header("Button ColorBlocks")]
        public ThemeButtonColorSchema buttonPrimary;
        public ThemeButtonColorSchema buttonSecondary;
        public ThemeButtonColorSchema buttonOutro;
    }
}


