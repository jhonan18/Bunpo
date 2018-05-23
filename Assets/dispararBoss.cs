using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispararBoss : MonoBehaviour {
    float maxSpeed = 300f;
    // Use this for initialization
    /*void Start () {
		
	}*/

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(-maxSpeed * Time.deltaTime, 0, 0);
        pos += velocity;
        transform.position = pos;
    }
}
