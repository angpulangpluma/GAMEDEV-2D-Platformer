using UnityEngine;
using System.Collections;

public class buffcollide : MonoBehaviour {

    private SpriteRenderer rends;

    public Sprite White;
    public Sprite Pink;
    public Sprite Orange;
    public Sprite Green;
    public Sprite AM;
    public Sprite BuffPink;
    public Sprite BuffOrange;
    public Sprite BuffGreen;
    public Sprite BuffAM;
    public Sprite Likepoints;
    public int points = 0;

    public int catalyst = 0;

    void Start()
    {
        rends = GetComponent<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D col1){


        if (rends.sprite == BuffPink || rends.sprite == BuffOrange || rends.sprite == BuffGreen || rends.sprite == BuffAM)
            buffcol(col1);

        if (rends.sprite == Likepoints && col1.gameObject.name == "all color ball")
            pointcoll();

    }

    void pointcoll()
    {

        scoreManager.addPoints(1);
        catalyst = 1;

    }

    void buffcol(Collider2D col1)
    {
        if (col1.gameObject.name == "all color ball")
        {
            catalyst = 1;

            //what ever color the char is that char change color depends on what color the buff is

            //collision to Pink buff
            if (rends.sprite == BuffPink)
                col1.gameObject.GetComponent<SpriteRenderer>().sprite = Pink;

            //collision to  Orange buff
            else if (rends.sprite == BuffOrange)
                col1.gameObject.GetComponent<SpriteRenderer>().sprite = Orange;

            //collision to Green buff
            else if (rends.sprite == BuffGreen)
                col1.gameObject.GetComponent<SpriteRenderer>().sprite = Green;

            //collision to AquaMarine buff
            else if (rends.sprite == BuffAM)
                col1.gameObject.GetComponent<SpriteRenderer>().sprite = AM;

        }

    }

    void Update()
    {
        if (catalyst != 0)
            Die();

    }

    void Die()
    {
        Destroy(gameObject);
    }


}
