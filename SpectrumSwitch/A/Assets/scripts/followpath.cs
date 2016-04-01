using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class followpath : MonoBehaviour {

	public enum follow
    {
        MoveTowards,
        Lerp

    }

    public follow type = follow.MoveTowards;
    public Path paths;
    public float Speed = 20;
    public float MaxDit = 0.3f;
    private IEnumerator<Transform> currentpath;

    public void Start()
    {
        if(paths == null)
        {
            Debug.LogError("Path cannot be null", gameObject);
            return;
        }

        currentpath = paths.GetPathsEnumerator();
        currentpath.MoveNext();

        if (currentpath.Current == null)
            return;

        transform.position = currentpath.Current.position;

    }

    public void Update()
    {
        if (currentpath == null || currentpath.Current == null)
            return;

        else if (type == follow.MoveTowards)
            transform.position = Vector3.MoveTowards(transform.position, currentpath.Current.position, Time.deltaTime * Speed);

        else if (type == follow.Lerp)
            transform.position = Vector3.Lerp(transform.position, currentpath.Current.position, Time.deltaTime * Speed);

        var sqrddistance = (transform.position - currentpath.Current.position).sqrMagnitude;

        if (sqrddistance < (MaxDit * MaxDit))
            currentpath.MoveNext();
    }
}
