using UnityEngine;
using System.Collections;

public class showpopup : MonoBehaviour {

    public bool popup;
    public GameObject that;
	
	// Update is called once per frame
	void Update () {

        if (popup == true)
        {
            that.SetActive(true);

        }

        else if (popup == false)
        {
            that.SetActive(false);
        }

    }

    public void pass()
    {

        popup = true;

    }

    void Start()
    {

        popup = false;

    }

    public void Game()
    {

        popup = false;

    }
}
