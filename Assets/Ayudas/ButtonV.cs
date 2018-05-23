using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonV : MonoBehaviour {
	//public GameObject Manejador;
	public ManejaAyuda manejador;
	public Canvas micanvas;
	public bool infoOpen=false;
	public Canvas canvas2;

	public  string textoboton;
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
			manejador.MostrarAyuda();
			Time.timeScale = 0;
		}
		else if (infoOpen == true) {
			infoOpen = false;
			micanvas.enabled = false;
			if (canvas2.enabled == true) {
				canvas2.enabled = false;
			}

			Time.timeScale = 1;
		}

	
	}
}
