using UnityEngine;
using UnityEngine.UI;

public class PaletteSwapSprite : MonoBehaviour
{
    [SerializeField]
    ColorVariable foregroundColor;

    [SerializeField]
    ColorVariable backgroundColor;

    Material material;

    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void LateUpdate()
    {
        material.SetColor("_FgColor", foregroundColor.Value);
        material.SetColor("_BgColor", backgroundColor.Value);
    }
}
