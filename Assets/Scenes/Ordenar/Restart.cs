﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour {

    private Scene scene;
	void Start () {
        scene = SceneManager.GetActiveScene();
        scene.GetType();
	}
	
	// Update is called once per frame
	public void restarteo () {
       // Application.LoadLevel(scene.name);
        SceneManager.LoadScene("Ordenar");
	}
}
