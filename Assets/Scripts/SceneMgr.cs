using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void loadSceneNS(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
