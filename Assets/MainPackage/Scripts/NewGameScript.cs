using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGameScript : MonoBehaviour
{
    public Button NewGameBtn;
    public Button QuitGameBtn;

    private void Awake()
    {
        // Attach button click listeners
        NewGameBtn.onClick.AddListener(StartGame);
        QuitGameBtn.onClick.AddListener(QuitGame);
    }

    private void StartGame()
    {
        // Switch to the Level0 scene
        SceneManager.LoadScene("Level0");
    }

    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}


