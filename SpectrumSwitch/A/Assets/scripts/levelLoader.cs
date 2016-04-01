using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour {

    public string loadit;
    public bool what;

	void Start()
    {

        what = false;

    }

    void OnTriggerEnter2D(Collider2D col4)
    {
        if(col4.gameObject.name == "all color ball")
        {
            what = true;

        }

    }
    
	void Update () {

        if(what == true)
        SceneManager.LoadScene(loadit);
	}
}
