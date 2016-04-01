using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    public string restartgame;
    public string home;
    public bool isPaused;

    public GameObject pausedMenuCanvas;

   	// Update is called once per frame
	void Update () {
        if(isPaused)
        {
            pausedMenuCanvas.SetActive(true);
        }else{
            pausedMenuCanvas.SetActive(false);
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
    public void Restart()
    {
        SceneManager.LoadScene(restartgame);

    }

    public void Home()
    {
        SceneManager.LoadScene(home);

    }
}
