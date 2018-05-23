using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour {
	public Color colorchange;
	public SpriteRenderer m_SpriteRenderer;
	public string Type;
	public string colorSeleccionado;
	public string ColorVerdadero;
	float speed=10f;
	float rebote=4f;
	public Vector3 mivec;
	public Vector3 vectemp;
	public Rigidbody2D rigid;
	public float padding;
	public Texture2D cursorTexture;
	public CursorMode cursormode = CursorMode.Auto;
	public Vector2 hotspot=Vector2.zero;

	// Use this for initialization
	void Start(){
		if (Type == "Predicado") {
			this.ColorVerdadero = "Verde";
		}
		if (Type == "Sujeto") {
			this.ColorVerdadero = "Azul";
		}
		if (Type == "Verbo") {
			this.ColorVerdadero = "Rojo";
		}

		rigid = transform.GetComponent<Rigidbody2D> ();
		rigid.GetComponent<Rigidbody2D> ();
	}
	void OnMouseDown(){

		if ( ManejadorJuego.ColorSeleccionado == "Verde") {

			m_SpriteRenderer = GetComponent<SpriteRenderer>();
			this.colorSeleccionado="Verde";
			m_SpriteRenderer.color = Color.green;
			Cursor.SetCursor (null, Vector2.zero, cursormode);
		}
		if (ManejadorJuego.ColorSeleccionado == "Rojo") {

			m_SpriteRenderer = GetComponent<SpriteRenderer>();
			this.colorSeleccionado="Rojo";
			m_SpriteRenderer.color = Color.red;
			Cursor.SetCursor (null, Vector2.zero, cursormode);
		}
		if ( ManejadorJuego.ColorSeleccionado == "Azul") {

			m_SpriteRenderer = GetComponent<SpriteRenderer>();
			this.colorSeleccionado="Azul";
			m_SpriteRenderer.color = Color.blue;
			Cursor.SetCursor (null, Vector2.zero, cursormode);
		}

	}

	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.tag == "SpaceShip") {
			
			GetComponent<Rigidbody2D> ().AddForce ((transform.position - col.gameObject.transform.position) * rebote/4, ForceMode2D.Impulse);
		} else {
			Vector3 direccion = transform.position - col.gameObject.transform.position;
			float auxX =0f;
			float auxY=0f;
			if(direccion.x == 0f){
				auxX = 0;
			}else if (direccion.x < 0f){
				auxX = -1f;
			}else if(direccion.x > 0f){
				auxX=1f;
			}

			if(direccion.y == 0f){
				auxY = 0;
			}else if (direccion.y < 0f){
				auxY = -1f;
			}else if(direccion.y > 0f){
				auxY=1f;
			}

			GetComponent<Rigidbody2D> ().AddForce (new Vector2(auxX,auxY) * rebote*2, ForceMode2D.Impulse);

		}
	}


	void Update(){
		transform.eulerAngles = new Vector3 (0f, 0f, 0f);

		rigid.AddForce (new Vector2 (Random.Range (-1f, 1f), Random.Range (-1f, 1f)) * speed/**Time.deltaTime*/);

	}

}