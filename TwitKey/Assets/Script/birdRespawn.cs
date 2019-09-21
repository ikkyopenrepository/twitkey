using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class birdRespawn : MonoBehaviour {

    public GameObject[] bird;
    private Transform respawnPosition;
    private Vector2 getPosition;
    private int randomNumber;

	// Use this for initialization
	void Start ()
    {
        respawnPosition = GetComponent<Transform>();
        getPosition = respawnPosition.position;
        StartCoroutine(respawnDelay());
    }

    void respawn()
    {
        randomNumber = Random.Range(0, 4);
        Instantiate(bird[randomNumber], getPosition, Quaternion.identity);
        StartCoroutine(respawnDelay());
    }

    IEnumerator respawnDelay()
    {
        randomNumber = Random.Range(2, 5);
        yield return new WaitForSeconds(randomNumber);
        respawn();
    }
}
