using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevisarSeleccion : MonoBehaviour {
	GameObject man;
	public ManejadorJuego manejador;
	public Canvas PanelInfoCanvas;
	public bool infoOpen=false;


									

	void Start () {
		

	}


	void Update () {
		
	}
	void InfoPanel(){

	}
	void OnMouseDown(){
		if (infoOpen == false) {
			infoOpen = true;
			//PanelInfoCanvas.enabled = true;
			manejador.ChangeText ();
			Time.timeScale = 0;
		}
		else if (infoOpen == true) {
			infoOpen = false;
			PanelInfoCanvas.enabled = false;
			Time.timeScale = 1;
		}

}
}
