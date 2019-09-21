using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MonoBehaviour
{

    [SerializeField]
    private Text scoreText = null;
    [SerializeField]
    private Text lastscoreText = null;

    public static int score;
	// Use this for initialization
	void Start ()
    {
        score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = "score : " + (int)score;
        lastscoreText.text = ""+(int)score ;
    }

}
