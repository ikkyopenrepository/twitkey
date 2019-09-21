using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject menuCanvas;
    public GameObject playingCanvas;
    public GameObject scoreCanvas;
    public GameObject line;
    public GameObject objectPoller;
    private Transform pollerPosition;
    private Vector2 getPosition;

    // Use this for initialization
    void Start ()
    {
        pollerPosition = GetComponent<Transform>();
        getPosition =pollerPosition.position;
        menuCanvas.SetActive(true);
        playingCanvas.SetActive(false);
        scoreCanvas.SetActive(false);
        line.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (CountDown.gameTime==false)
        {
            menuCanvas.SetActive(false);
            playingCanvas.SetActive(false);
            scoreCanvas.SetActive(true);
            line.SetActive(false);
        }
	}

    public void Button_Click()
    {
        menuCanvas.SetActive(false);
        playingCanvas.SetActive(true);
        line.SetActive(true);
        LineScript.score = 0;
        Instantiate(objectPoller, getPosition, Quaternion.identity);
        CountDown.timeSwitch = true;
        CountDown.gameTime = true;
        CountDown.timeRemaining = 60;
        LineScript.score = 0;
    }

    public void Button_Again()
    {
        scoreCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        playingCanvas.SetActive(true);
        line.SetActive(true);
        LineScript.score = 0;
        Instantiate(objectPoller, getPosition, Quaternion.identity);
        CountDown.timeSwitch = true;
        CountDown.gameTime = true;
        CountDown.timeRemaining = 60;
        LineScript.score = 0;
    }
    public void Button_Exit()
    {
        Application.Quit();
    }

}
