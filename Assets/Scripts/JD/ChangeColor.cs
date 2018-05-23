using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
	public Color colorchange;
	public string Type;
	// Use this for initialization

	void OnMouseDown(){
		if (Type == "Predicado" && GameMasColor.ColorSeleccionado == "Verde") {
			Debug.Log ("mouse over object");
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.green;
		}
		if (Type == "Verbo" && GameMasColor.ColorSeleccionado == "Rojo") {
			Debug.Log ("mouse over object");
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
		}
		if (Type == "Sujeto" && GameMasColor.ColorSeleccionado == "Azul") {
			Debug.Log ("mouse over object");
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.blue;
		}
	}
	/*void OnMouseExit(){
		Debug.Log ("Mouse Exit Object"); 
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;

	}*/
}

