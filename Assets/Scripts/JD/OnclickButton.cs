using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickButton : MonoBehaviour {
	public string Color;
	public Texture2D cursorTexture;
	public CursorMode cursormode = CursorMode.Auto;
	public Vector2 hotspot=Vector2.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		GameMasColor.ColorSeleccionado = Color;
		ManejadorJuego.ColorSeleccionado = Color;
		//Cursor.SetCursor (cursorTexture, hotspot, cursormode);

	}
}
