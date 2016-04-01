using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    public string restartgame;
    public string home;
    public bool isPaused;

<<<<<<< HEAD
    public string restra;
    public string home;
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
=======
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
>>>>>>> origin/master

    }

    public void Home()
    {
<<<<<<< HEAD

        SceneManager.LoadScene(home);

    }

    public void restart()
    {

        SceneManager.LoadScene(restra);
    }

=======
        SceneManager.LoadScene(home);

    }
>>>>>>> origin/master
}
