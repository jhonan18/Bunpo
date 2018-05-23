using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemplosV : MonoBehaviour {

	public ManejadorJuego manejador;
	public Canvas canvassujej;
	public Canvas canvaspredej;
	public Canvas canvas2;
	public string tipo="Verbo";
	public Canvas canvas1;
	public bool infoOpen=false;
	// Use this for initialization
	void Start () {
	}


	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown(){
		tipo = manejador.retornotipoactual();
		if (tipo == "Verbo") {


			if (infoOpen == false) {
				infoOpen = true;
				canvas1.enabled = false;
				canvas2.enabled = true;
			//		manejador.MostrarEjemplos();
				Time.timeScale = 0;
			}
			else if (infoOpen == true) {
				infoOpen = false;
				canvas2.enabled = false;
				Time.timeScale = 1;
			}




		}
		else if (tipo == "Sujeto") {


			if (infoOpen == false) {
				infoOpen = true;
				canvas1.enabled = false;
				canvassujej.enabled = true;
				//manejador.MostrarEjemplos();
				Time.timeScale = 0;
			}
			else if (infoOpen == true) {
				infoOpen = false;
				canvassujej.enabled = false;
				Time.timeScale = 1;
			}




		}
	
		else if (tipo == "Predicado") {


			if (infoOpen == false) {
				infoOpen = true;
				canvas1.enabled = false;
				canvaspredej.enabled = true;
				//manejador.MostrarEjemplos();
				Time.timeScale = 0;
			}
			else if (infoOpen == true) {
				infoOpen = false;
				canvaspredej.enabled = false;
				Time.timeScale = 1;
			}




		}

	}
	public void cambiartipo(string mitipo){
		this.tipo = mitipo;
	}
}
