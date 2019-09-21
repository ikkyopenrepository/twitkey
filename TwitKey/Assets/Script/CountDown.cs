using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
  
    [SerializeField]
    private Text timeText = null;
    public static float timeRemaining;
    public static bool timeSwitch;
    public static bool gameTime;
    // Use this for initialization

    void Start ()
    {
        timeSwitch = false;
        gameTime = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timeSwitch)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                gameTime = false;
            }
        }
        timeText.text = "time : "+(int)timeRemaining ;
	}
}
