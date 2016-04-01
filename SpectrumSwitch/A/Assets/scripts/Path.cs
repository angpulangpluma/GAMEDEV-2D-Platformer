using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Path : MonoBehaviour {

    public Transform[] Points;

    public IEnumerator<Transform> GetPathsEnumerator()
    {

        if (Points == null || Points.Length < 1)
            yield break;

        var index = 0;
        //var direction = 1;

        while (true)
        {
            yield return Points[index];
            index += 1;


           // if (Points.Length == 1)
                //continue;

            //if (index <= 0)
            //    direction = 1;

            if (index == Points.Length)
                index = 0;

            //index = index + direction;
            
        }

    }

    public void OnDrawGizmos()
    {

        if (Points == null || Points.Length < 2)
            return;


        for (var a = 1; a < Points.Length; a++)
        {

            Gizmos.DrawLine(Points[a - 1].position, Points[a].position);

        }
            
    }
	
}
