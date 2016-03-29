using UnityEngine;
using System.Collections;

public class CameraView : MonoBehaviour
{

    // Set Player in the Editor.
    public GameObject Player;
    // Set CamerOffset in the Editor.
    public Vector2 CamerOffset;

    Vector3 cameraPosition;

    // Use this for initialization
    void Start()
    {
        cameraPosition = new Vector3(0, 0, -10.0f);
    }

    void Update()
    {
        cameraPosition.x = Player.transform.position.x + CamerOffset.x;
        cameraPosition.y = Player.transform.position.y + CamerOffset.y;
        this.transform.position = cameraPosition;
    }

}