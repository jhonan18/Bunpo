using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasEmergente : MonoBehaviour {

    public Canvas instrucciones;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeVisibility()
    {
        if (!instrucciones.enabled)
        {
            //Time.timeScale = 0;
        }
        else
        {
            //Time.timeScale = 1;
        }
        instrucciones.enabled = !instrucciones.enabled;
    }
}
