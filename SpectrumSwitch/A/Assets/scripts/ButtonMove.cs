using UnityEngine;
using System.Collections;

public class ButtonMove : MonoBehaviour {

    public float speed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Left()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }

    public void Right()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

    }

    public void Jump()
    {
        transform.position += Vector3.up * 20 * Time.deltaTime;

    }
}
