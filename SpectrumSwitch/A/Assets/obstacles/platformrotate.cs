using UnityEngine;
using System.Collections;

public class platformrotate : MonoBehaviour {


    void Update()
    {
        transform.Rotate(Vector3.forward * -2);

    }
}
