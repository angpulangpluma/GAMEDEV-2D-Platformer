using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            RotateLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            RotateRight();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * 20 * Time.deltaTime;
        }
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.back * -10);

    }

    void RotateRight()
    {
        transform.Rotate(Vector3.forward * -10);

    }

}
