using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePath
{
    public Vector2 startMove = new Vector2(30, 30);
    public Vector2 acceleration = new Vector2(10, -20);
    public Vector3 startPosition { get; set; }
    public Vector3 endPosition { get; set; }
    private Vector3 direction;

    public Vector3 screenPosition {
        set
        {
            Debug.Log(value);
            Vector3 v3 = Camera.main.ScreenToWorldPoint(value);
            v3.z = 0;
            endPosition = v3;
            Debug.Log(endPosition);
        }
    }


    public void ready()
    {
        direction = Vector3.Normalize(endPosition - startPosition);
    }

    public Vector3 pathPosition(float time)
    {
        Vector3 v3 = startPosition;
        v3.x += direction.x * startMove.x * time + time * time * direction.x * acceleration.x;
        v3.y += direction.y * startMove.y * time + time * time * acceleration.y;
        return v3;
    }
}
