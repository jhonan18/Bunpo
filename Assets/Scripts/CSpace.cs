using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSpace : MonoBehaviour {
    
    public CoheteController cohete;

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void moverCohete(Planeta_GeneralController plan)
    {
        cohete.setTarget(plan);
    }
}
