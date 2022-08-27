using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Theme
{
    public enum ImageColors
    {
        imageSolidBg,
        formSolidBg
    }

    public enum TextColors
    {
        textPrimary,
        textSecondary,
        textButton,
        textError
    }

    public enum Fonts
    {
        fontRegular
    }

    public enum ButtonColors
    {
        buttonPrimary,
        buttonSecondary,
        buttonOutro
    }

    public class ThemeManager : MonoBehaviour
    {
        [SerializeField] private ThemeColorSchema themeColorSchema;

        public delegate void ThemeEvent(ThemeManager themeManager);
        public static event ThemeEvent OnInit;

        private void Start()
        {
            // Only call once for now...
            // TODO: when adding more themes need to check for updates and call again
            OnInit?.Invoke(this);
        }

        public Color GetImageThemedColor(ImageColors option)
        {
            switch (option)
            {
                case ImageColors.imageSolidBg:
                    return themeColorSchema.imageSolidBg;
                case ImageColors.formSolidBg:
                    return themeColorSchema.formSolidBg;
                default:
                    return new Color(1, 1, 1, 1); //Fallback
            }
        }

        public Color GetTextThemedColor(TextColors option)
        {
            switch (option)
            {
                case TextColors.textPrimary:
                    return themeColorSchema.textPrimary;
                case TextColors.textSecondary:
                    return themeColorSchema.textSecondary;
                case TextColors.textButton:
                    return themeColorSchema.textButton;
                case TextColors.textError:
                    return themeColorSchema.textError;
                default:
                    return new Color(1, 1, 1, 1); //Fallback
            }
        }

        public TMP_FontAsset GetTextThemedFont(Fonts option)
        {
            switch (option)
            {
                case Fonts.fontRegular:
                default:
                    return themeColorSchema.fontRegular; //Fallback
            }
        }

        public ColorBlock GetButtonColor(ButtonColors option)
        {
            switch (option)
            {
                case ButtonColors.buttonPrimary:
                    return themeColorSchema.buttonPrimary.GetColorBlock();
                case ButtonColors.buttonSecondary:
                    return themeColorSchema.buttonSecondary.GetColorBlock();
                case ButtonColors.buttonOutro:
                    return themeColorSchema.buttonOutro.GetColorBlock();
                default:
                    return new ColorBlock(); //Fallback
            }
        }

    }
}