using UnityEngine;
using System.Collections;

public class scoretextview : MonoBehaviour {

    // Set Player in the Editor.
    public GameObject Player;
    // Set CamerOffset in the Editor.
    public Vector2 stOffset;

    Vector3 stPosition;

    // Use this for initialization
    void Start()
    {
        stPosition = new Vector3(0, 0, -1.0f);
    }

    void Update()
    {
        stPosition.x = Player.transform.position.x + stOffset.x - 32;
        stPosition.y = Player.transform.position.y + 14 + stOffset.y;
        this.transform.position = stPosition;
    }
}
