﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

    public static int score;

    Text text;

    void Start()
    {

        text = GetComponent<Text>();

        score = 0;

    }

    void Update()
    {

        if (score < 0)
            score = 0;

        text.text = "" + score;
    }

    public static void addPoints(int pointsadd)
    {

        score += pointsadd;

    }

    public static void Reset()
    {

        score = 0;

    }

}
