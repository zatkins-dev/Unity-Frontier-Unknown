using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;

[CreateAssetMenu(fileName="UIConfig", menuName = "ScriptableObjects/UIConfig")]
public class UIConfig : ScriptableObject
{
    [Serializable]
    public struct ColorPalette
    {
        public Color Primary;
        public Color PrimaryLight;
        public Color PrimaryDark;
        public Color PrimaryText;
        public Color Secondary;
        public Color SecondaryLight;
        public Color SecondaryDark;
        public Color SecondaryText;
        public Color Background;
        public Color LightBackground;
    };
    [Header("Color Palette")]
     public ColorPalette colorPalette = new ColorPalette {
        Primary = new Color32(0x42, 0x42, 0x42, 0xff),
        PrimaryLight = new Color32(0x6d, 0x6d, 0x6d, 0xff),
        PrimaryDark = new Color32(0x1b, 0x1b, 0x1b, 0xff),
        PrimaryText = Color.white,
        Secondary = new Color32(0x80, 0xcb, 0xc4, 0xff),
        SecondaryLight = new Color32(0xb2, 0xfe, 0xf7, 0xff),
        SecondaryDark = new Color32(0x4f, 0x9a, 0x94, 0xff),
        SecondaryText = Color.black,
        Background = new Color32(0xE1,0xE2,0xE1,0xFF),
        LightBackground = new Color32(0xF5, 0xF5, 0xF6, 0xFF),
    };
    [Header("Font")]
    public TMP_FontAsset titleFont;
    public TMP_FontAsset bodyFont;

    [Serializable]
    public struct ButtonColorBlocks
    {
        public ColorBlock Default;
        public ColorBlock Light;
        public ColorBlock Dark;
        public ColorBlock Background;
    };
    [Header("Button Colors")]
    public ButtonColorBlocks buttonColors;

    static UIConfig _instance = null;
    public static UIConfig Instance
    {
        get
        {
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<UIConfig>().FirstOrDefault();
            return _instance;
        }
    }

    private void OnValidate()
    {
        if (buttonColors.Default.normalColor != colorPalette.Secondary)
            buttonColors.Default = ComputeButtonColorBlock(colorPalette.Secondary);
        if (buttonColors.Light.normalColor != colorPalette.SecondaryLight)
            buttonColors.Light = ComputeButtonColorBlock(colorPalette.SecondaryLight);
        if (buttonColors.Dark.normalColor != colorPalette.SecondaryDark)
            buttonColors.Dark = ComputeButtonColorBlock(colorPalette.SecondaryDark);
        if (buttonColors.Background.normalColor != colorPalette.Background)
            buttonColors.Background = ComputeButtonColorBlock(colorPalette.Background);
    }

    private ColorBlock ComputeButtonColorBlock(Color baseColor)
    {
        Color.RGBToHSV(baseColor, out float H, out float S, out float V);
        ColorBlock colors = new ColorBlock()
        {
            normalColor = baseColor,
            highlightedColor = Color.HSVToRGB(H, S, V - 0.04f),
            pressedColor = Color.HSVToRGB(H, S, V - 0.22f),
            selectedColor = Color.HSVToRGB(H, S, V - 0.04f),
            disabledColor = Color.HSVToRGB(H, S - 0.22f, V - 0.22f),
            colorMultiplier = 1,
            fadeDuration = 0.1f,
        };
        var disabledColor = colors.disabledColor;
        disabledColor.a = 0.5f;
        colors.disabledColor = disabledColor;
        return colors;
    }
}
#if UNITY_EDITOR
static class MySingletonMenuItems
{
    [MenuItem("UI/Button/Default")]
    static void StylizeButton()
    {
        if (Selection.activeGameObject.GetComponent<Button>())
        {
            var button = Selection.activeGameObject.GetComponent<Button>();
            button.colors = UIConfig.Instance.buttonColors.Default;

            var text = Selection.activeGameObject.GetComponentInChildren<TMP_Text>();
            if (text)
            {
                text.font = UIConfig.Instance.bodyFont;
                text.color = UIConfig.Instance.colorPalette.SecondaryText;
            }
        }
    }
    [MenuItem("UI/Button/Light")]
    static void StylizeButtonLight()
    {
        if (Selection.activeGameObject.GetComponent<Button>())
        {
            var button = Selection.activeGameObject.GetComponent<Button>();
            button.colors = UIConfig.Instance.buttonColors.Light;

            var text = Selection.activeGameObject.GetComponentInChildren<TMP_Text>();
            if (text)
            {
                text.font = UIConfig.Instance.bodyFont;
                text.color = UIConfig.Instance.colorPalette.SecondaryText;
            }
        }
    }
    [MenuItem("UI/Button/Dark")]
    static void StylizeButtonDark()
    {
        if (Selection.activeGameObject.GetComponent<Button>())
        {
            var button = Selection.activeGameObject.GetComponent<Button>();
            button.colors = UIConfig.Instance.buttonColors.Dark;

            var text = Selection.activeGameObject.GetComponentInChildren<TMP_Text>();
            if (text)
            {
                text.font = UIConfig.Instance.bodyFont;
                text.color = UIConfig.Instance.colorPalette.SecondaryText;
            }
        }
    }
    [MenuItem("UI/StylizePanels")]
    static void StylizePanels() 
    {
        foreach (var image in Selection.activeGameObject.GetComponentsInChildren<Image>()) {
            image.color = UIConfig.Instance.colorPalette.Background;
        }
    }
    [MenuItem("UI/ReplaceAllFonts")]
    static void FixFonts()
    {
        foreach (var text in Resources.FindObjectsOfTypeAll<GameObject>().Where(go => go.GetComponent<TMP_Text>()!=null && !go.CompareTag("Title") ).Select( go=>go.GetComponent<TMP_Text>()) )
        {
            text.font = UIConfig.Instance.bodyFont;
        }
    }
}
#endif
