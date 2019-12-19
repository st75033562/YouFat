using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    [SerializeField]
    private GameObject[] gos;

    public Rigidbody rigibody;

	// Use this for initialization
	void Start () {

        rigibody.AddRelativeForce(new Vector3(300,300,0));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
