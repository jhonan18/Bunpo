using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permanente : MonoBehaviour {

    static Permanente instance;
	void Start () {
        if (instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            instance = this;
        }
	}
	
	
}
