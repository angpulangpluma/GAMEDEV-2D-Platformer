using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class buttonMovement : MonoBehaviour, IEventSystemHandler
{
    public GameObject character;
    public float maxSpeed = 20f;
    bool buttonHeld = false;
    public Button rytButton;
    public Button lepButton;
    public Button upButton;
    public GameObject buts;

    public void pressed(BaseEventData eventData)
    {
        buttonHeld = true;

    }
    public void notpressed(BaseEventData eventData)
    {
        buttonHeld = false;
    }
    void Start()
    {
        character = GameObject.FindWithTag("Player");
    }
    public void Update()
    {
        buts = EventSystem.current.currentSelectedGameObject;
        if (buttonHeld == true)
        {
            if(buts.name == "Right Button")
                character.transform.position += Vector3.right * maxSpeed * Time.deltaTime;

            else if(buts.name == "Left Button")
               character.transform.position += Vector3.left * maxSpeed * Time.deltaTime;

            if(buts.name == "Jump Button")
               character.transform.position += Vector3.up * maxSpeed * Time.deltaTime;
        }

    }
}
