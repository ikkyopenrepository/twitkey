using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPDestroy : MonoBehaviour
{

    public GameObject objectPoller;

	// Update is called once per frame
	void Update ()
    {
        if (CountDown.gameTime == false)
        {
            Destroy(objectPoller);
        }
	}
}
