#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ������ ��� �������� ������� ������ ������� ��������
/// </summary>
public class IconAndTextSetter : MonoBehaviour
{
    public Sprite Icon;
    public string Text;

    public Image icon;
    public TextMeshProUGUI text;

    private void OnValidate()
    {
        icon.sprite = Icon;
        text.text = Text;
    }
} 
#endif
