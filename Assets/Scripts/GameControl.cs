﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake ()
    {
		if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gameOver == true && Input.GetMouseButtonDown(0)) // True and Leftclick
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload currently active scene
        }
	}

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
