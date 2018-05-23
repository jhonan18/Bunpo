using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEmergenteMundo : MonoBehaviour {

    public Canvas instrucciones1;
    public Canvas instrucciones2;
    public Canvas instrucciones3;
    public Canvas cuadricula;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mostrarCanvas(int n)
    {
        if (n == -1)
        {
            if (instrucciones1.enabled || instrucciones2.enabled || instrucciones3.enabled)
            {
                instrucciones1.enabled = false;
                instrucciones2.enabled = false;
                instrucciones3.enabled = false;
                cuadricula.enabled = true;
            }
            else
            {
                instrucciones1.enabled = true;
                instrucciones2.enabled = false;
                instrucciones3.enabled = false;
                cuadricula.enabled = false;
            }
        }
        else if (n == 1)
        {
            instrucciones1.enabled = true;
            instrucciones2.enabled = false;
            instrucciones3.enabled = false;
        }
        else if (n == 2)
        {
            instrucciones1.enabled = false;
            instrucciones2.enabled = true;
            instrucciones3.enabled = false;
        }
        else
        {
            instrucciones1.enabled = false;
            instrucciones2.enabled = false;
            instrucciones3.enabled = true;
        }
    }



}
