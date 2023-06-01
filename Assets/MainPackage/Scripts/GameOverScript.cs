using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScript : MonoBehaviour
{
    public Button Retrybtn;
    public Button Quitbtn;
    public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        // Retrybtn.onClick.AddListener(RestartGame);
        
        GameOverScreen.SetActive(false);
    }

    // public void RestartGame(){
    //     SceneManager.LoadScene(Level0);
    // }

    public void ShowGameOverScreen(){
        GameOverScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
