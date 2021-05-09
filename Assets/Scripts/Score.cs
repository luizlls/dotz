using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;

    [SerializeField]
    CountVariable score;

    [SerializeField]
    ColorVariable color;

    void Awake()
    {
        score.Value = 0;
    }

    void LateUpdate()
    {
        scoreText.text = score.Value.ToString();
        scoreText.color = color.Value;
    }
}
