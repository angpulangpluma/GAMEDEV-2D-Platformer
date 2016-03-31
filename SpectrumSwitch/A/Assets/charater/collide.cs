using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

    private SpriteRenderer rends;

    public Sprite White;
    public Sprite Pink;
    public Sprite Orange;
    public Sprite Green;
    public Sprite AM;
    public Sprite PlatPink;
    public Sprite PlatOrange;
    public Sprite PlatGreen;
    public Sprite PlatAM;
    public Sprite PlatPink2;
    public Sprite PlatOrange2;
    public Sprite PlatGreen2;
    public Sprite PlatAM2;
    public Sprite CircPink;
    public Sprite CircOrange;
    public Sprite CircGreen;
    public Sprite CircAM;
    public Sprite EndDoor;

    public int dest = 0;
    public int end = 0;

    void Start()
    {
        rends = GetComponent<SpriteRenderer>();

    }
    
    void OnTriggerEnter2D(Collider2D col3)
    {
        if (rends.sprite == Pink || rends.sprite == Orange || rends.sprite == Green || rends.sprite == AM || rends.sprite == White && gameObject.name == "all color ball")
            circcol(col3);

    }

    void OnCollisionEnter2D(Collision2D col2)
    {

        if (rends.sprite == Pink || rends.sprite == Orange || rends.sprite == Green || rends.sprite == AM || rends.sprite == White && gameObject.name == "all color ball")
            Platcol(col2);


    }

    void circcol(Collider2D col3)
    {

        if (rends.sprite == White)
        {
            if (col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircPink || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircOrange || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircGreen || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircAM)
                dest = 1;
        }

        else if (rends.sprite == Pink)
        {
            if (col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircOrange || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircGreen || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircAM)
                dest = 1;
        }

        else if (rends.sprite == Orange)
        {
            if (col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircPink || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircGreen || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircAM)
                dest = 1;
        }

        else if (rends.sprite == Green)
        {
            if (col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircPink || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircOrange || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircAM)
                dest = 1;
        }

        else if (rends.sprite == AM)
        {
            if (col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircPink || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircOrange || col3.gameObject.GetComponent<SpriteRenderer>().sprite == CircGreen)
                dest = 1;
        }

    }

    void Platcol(Collision2D col2)
    {

            if (rends.sprite == White)
            {
                if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM2)
                    dest = 1;
            }

            else if (rends.sprite == Pink)
            {
                if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM2)
                    dest = 1;
            }

            else if (rends.sprite == Orange)
            {
                if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM2)
                    dest = 1;
            }

            else if (rends.sprite == Green)
            {
                if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatAM2)
                    dest = 1;
            }

            else if (rends.sprite == AM)
            {
                if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatPink2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatOrange2 || col2.gameObject.GetComponent<SpriteRenderer>().sprite == PlatGreen2)
                    dest = 1;
            }

            else if(rends.sprite == White || rends.sprite == Pink || rends.sprite == Orange || rends.sprite == Green || rends.sprite == AM && gameObject.name == "all color ball")
            {
            if (col2.gameObject.GetComponent<SpriteRenderer>().sprite == EndDoor)
                {
                    end = 1;
                Ending(end);
                }
            }

    }

    void Ending(int end)
    {

        //change scene
    }

    void Update()
    {
        if (dest == 1)
        {
            Destroy(gameObject);
            end = 0;
            Ending(end);
        }
    }
}
