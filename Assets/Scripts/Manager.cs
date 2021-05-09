using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public enum GameState
{
    Initial,
    Started,
    Paused,
    Running,
    Over,
}


public class Manager : MonoBehaviour
{
    [SerializeField]
    CountVariable score;

    [SerializeField]
    ColorVariable backgroundColor;

    [SerializeField]
    ColorVariable foregroundColor;

    private GameState state = GameState.Initial;

    void Awake()
    {
        Time.timeScale = 0;
    }

    void Start()
    {
        var color = GetRandomColor();
        foregroundColor.Value = color.Foreground;
        backgroundColor.Value = color.Background;
        Camera.main.backgroundColor = backgroundColor.Value;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            if (state == GameState.Initial) {
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        state = GameState.Started;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        state = GameState.Paused;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        state = GameState.Running;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    CustomColor GetRandomColor()
    {
        return Colors.colors[Random.Range(0, Colors.colors.Length)];
    }
}
