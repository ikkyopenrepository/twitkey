using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charUp : MonoBehaviour
{

    public GameObject bird;
    public bool key;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && key)
        {
            Destroy(bird);
            LineScript.score += 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Line")
        {
            print("Kena");
            key = true;
        } else if (other.transform.tag == "Line_")
        {
            print("Lepas");
            key = false;
        }
        if (other.transform.tag == "Destroy")
        {
            Destroy(bird);
        }
    }
}
