using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakChar : MonoBehaviour
{
    private Rigidbody2D myRigid;
    public float gayaDorong;

    // Use this for initialization
    void Start ()
    {
        myRigid = GetComponent<Rigidbody2D>();
        gayaDorong = Random.Range (2, 8);
    }
	
	// Update is called once per frame
	void Update () {
        myRigid.velocity = Vector2.right * gayaDorong ;
    }
}
