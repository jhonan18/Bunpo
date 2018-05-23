using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta5Controller : MonoBehaviour {

    public CoheteController coheteController;
    public string escena;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (coheteController.distancia(coheteController.transform.position, transform.position) == 0)
        {
            coheteController.setEscenaDestruida(true);
            SceneMgr.loadScene(escena);
        }
	}
}
