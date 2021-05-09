using UnityEngine;
using UnityEngine.UI;

public class PaletteSwapImage : MonoBehaviour
{
    [SerializeField]
    ColorVariable foregroundColor;

    [SerializeField]
    ColorVariable backgroundColor;

    Material material;

    void Awake()
    {
        material = GetComponent<Image>().material;
    }

    void LateUpdate()
    {
        material.SetColor("_FgColor", foregroundColor.Value);
        material.SetColor("_BgColor", backgroundColor.Value);
    }
}
