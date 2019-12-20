using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public LineRenderer line;
    [SerializeField]
    private GameObject[] gos;

    public Rigidbody rigibody;
    private Vector3 startV3;
    private Vector3 moveV3;
    private MovePath movePath;

    // Use this for initialization
    void Start () {
        movePath = new MovePath();
        movePath.startPosition = rigibody.gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            movePath.screenPosition = Input.mousePosition;
            movePath.ready();
            RrawLine();
        }
	}

    void RrawLine()
    {
        Vector3[] v3 = new Vector3[21];
        v3[0] = movePath.startPosition;
        for (int i = 0; i < 20; i++)
        {
            float t = i * Time.fixedDeltaTime;
            v3[i + 1] = movePath.pathPosition(t);
        }
        line.SetPositions(v3);
        tt = 0;
        startMove = true;
    }

    private bool startMove;
    private float tt;
    void FixedUpdate()
    {
        //if (startMove)
        //{
        //    tt += Time.fixedDeltaTime;
        //    Vector3 v3 = startV3;
        //    v3.x += moveV3.x * 30 * tt + tt * tt * moveV3.x * 10;
        //    v3.y += moveV3.y * 30 * tt + tt * tt * -20;
        //    rigibody.gameObject.transform.position = v3;
        //}
    }

    
}
