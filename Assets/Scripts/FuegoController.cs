using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoController : MonoBehaviour {

    private Animator animator;
    private bool onFire;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        onFire = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (onFire)
        {
            animator.SetBool("FireOn",true);
        } else
        {
            animator.SetBool("FireOn", false);
        }
	}

    public void setOnFire(bool b)
    {
        onFire = b;
    }
}
