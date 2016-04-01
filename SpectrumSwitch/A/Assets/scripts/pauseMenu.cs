using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    public string restartgame;
    public string home;
    public bool isPaused;

<<<<<<< HEAD
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


=======
    public string restra;
    public bool paused;
    public GameObject pausing;

    public void Update()
    {
        if(paused == true)
        {
            pausing.SetActive(true);
            Time.timeScale = 0f;

        }

        else if (paused == false)
        {
            pausing.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            paused = !paused;


    }

    public void pass()
    {

        paused = true;

    }

    void Start()
    {

        paused = false;

    }

    public void Game()
    {

        paused = false;

    }
>>>>>>> origin/master
}
