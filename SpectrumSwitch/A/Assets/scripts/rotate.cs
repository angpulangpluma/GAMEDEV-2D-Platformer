using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

    void Update()
    {
        transform.Rotate(Vector3.forward * -2);

    }
}
