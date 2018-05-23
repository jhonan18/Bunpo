using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileMgrController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void load()
    {
        Persistencia.load();
    }

    public void save()
    {
        Persistencia.save();
    }
}
