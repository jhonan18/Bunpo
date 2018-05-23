using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAyuda : MonoBehaviour {
	public Canvas micanvas;
	public bool infoOpen=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
	//	manejador.Ayuda = this.GetComponentInChildren<TextMesh>().text;
		if (micanvas.enabled==true) {
			micanvas.enabled = false;
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
			}
			if (Time.timeScale == 0) {
				Time.timeScale = 1;
			}
			//manejador.CerrarSonido ();
		}
		}
}
