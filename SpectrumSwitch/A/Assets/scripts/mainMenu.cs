using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public string startlevel;
    public string restartgame;
    public string home;
    public string setting;
    public string inst;

    public void Play()
    {

        SceneManager.LoadScene(startlevel);

    } 

    public void Restart()
    {
        SceneManager.LoadScene(restartgame);

    }

    public void Home()
    {
        SceneManager.LoadScene(home);

    }

    public void Settings()
    {
        SceneManager.LoadScene(setting);

    }

    public void Inst()
    {
        SceneManager.LoadScene(inst);

    }

    public void exitGame()
    {

        Application.Quit();

    }


}
