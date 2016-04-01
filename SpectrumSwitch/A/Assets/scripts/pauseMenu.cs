using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    public string restartgame;
    public string home;
    public bool isPaused;

    public GameObject pausedMenuCanvas;

   
	void Update () {
        if(isPaused)
        {
            pausedMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else{
            pausedMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
	
	}
    public void Pause()
    {
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }
  

    public void Home()
    {

        SceneManager.LoadScene(home);

    }

    public void Restart()
    {

        SceneManager.LoadScene(restartgame);
    }



   
}
