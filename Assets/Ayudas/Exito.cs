using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Exito : MonoBehaviour {
	public ManejaAyuda manejador;
	public bool infoOpen;
	public Canvas micanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		manejador.Ayuda = this.GetComponentInChildren<TextMesh>().text;
		if (infoOpen == false) {
			infoOpen = true;
			micanvas.enabled = true;
			manejador.MostrarExito();
			Time.timeScale = 0;
		}
		else if (infoOpen == true) {
			infoOpen = false;
			micanvas.enabled = false;
			manejador.CerrarSonido ();
			//manejador.misonido.enabled = false;
			Time.timeScale = 1;
		}


	}
}
