using UnityEngine;
using System.Collections;

public class backgroundview : MonoBehaviour {

    // Set Player in the Editor.
    public GameObject Player;
    // Set CamerOffset in the Editor.
    public Vector2 bgOffset;

    Vector3 bgPosition;

    // Use this for initialization
    void Start()
    {
        bgPosition = new Vector3(0, 0, 1.0f);
    }

    void Update()
    {
        bgPosition.x = Player.transform.position.x + bgOffset.x;
        bgPosition.y = Player.transform.position.y + bgOffset.y;
        this.transform.position = bgPosition;
    }
}
