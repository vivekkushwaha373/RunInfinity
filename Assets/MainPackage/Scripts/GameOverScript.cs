using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Button RetryBtn;
    public Button QuitBtn;

    private void Awake()
    {
        // Attach button click listeners
        RetryBtn.onClick.AddListener(RetryGame);
        QuitBtn.onClick.AddListener(QuitGame);
    }

    private void RetryGame()
    {
        // Switch to the Level0 scene to restart the game
        SceneManager.LoadScene("Level0");
    }

    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}

