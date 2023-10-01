#if UNITY_EDITOR
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Скрипт для быстрого конфига карточки героя
/// </summary>
public class HeroCardSetter : MonoBehaviour
{
    public int Level;

    public TextMeshProUGUI levelText;
    public Image BG;
    public Image Icon;
    public Color color;

    private void OnValidate()
    {
        BG.color = new Color(color.r, color.g, color.b, BG.color.a);

        Color.RGBToHSV(color, out float h, out float s, out float v);
        var icon = Color.HSVToRGB(h, 0.7f, 1);
        Icon.color = icon;
        
        levelText.text = Level.ToString();
    }
} 
#endif
