using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasColor : MonoBehaviour {
	public static string ColorSeleccionado;
	public static int Numpieces=9;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Numpieces == 0) {
			ColorSeleccionado = "HOILA0;";
		}
	}
}
