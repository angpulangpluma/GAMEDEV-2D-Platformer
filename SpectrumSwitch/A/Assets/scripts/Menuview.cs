using UnityEngine;
using System.Collections;

public class Menuview : MonoBehaviour {

    // Set Player in the Editor.
    public GameObject Player;
    // Set CamerOffset in the Editor.
    public Vector2 menuOffset;

    Vector3 menuPosition;

    // Use this for initialization
    void Start()
    {
        menuPosition = new Vector3(0, 0, -1.0f);
    }

    void Update()
    {
        menuPosition.x = Player.transform.position.x + 34 + menuOffset.x;
        menuPosition.y = Player.transform.position.y + 14 + menuOffset.y;
        this.transform.position = menuPosition;
    }
}
