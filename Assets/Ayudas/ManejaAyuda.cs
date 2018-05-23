using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManejaAyuda : MonoBehaviour {
	public string Ayuda="Verbo";
	public Text Escrito;
	public Text Escrito1;
	public Text Escritop;
	public static string tipo;
	public AudioSource misonido;
	public EjemplosV miejemplo;
	public int puntaje;
	//public string escr;
	// Use this for initialization
	void Start () {
		
	}
	public void MostrarAyuda(){
		
		//miejemplo.tipo=Ayuda;
		Escrito = GameObject.FindGameObjectWithTag ("AyudaCon").GetComponent<Text> ();
		if (this.Ayuda == "Verbo") {
			Escrito.text = "Los Verbos son las palabras que utilizanos para expresar acciones estados y procesos";
		}
		if (this.Ayuda == "Sujeto") {
			Escrito.text = "El sujeto es aquel que realiza la accion dentro de la frase";
		}
		if (this.Ayuda == "Predicado") {
			Escrito.text = "El predicado es aquella palabra que permite especificar mas como el sujeto realiza la accion , de que modo o manera";
		}
	
	}
	public void MostrarExito(){
		Escrito1 = GameObject.FindGameObjectWithTag ("pu").GetComponent<Text> ();
		Escrito1.fontSize = 20;
		Escritop= GameObject.FindGameObjectWithTag ("puntos").GetComponent<Text> ();
		if (this.Ayuda == "Exito") {
			Escrito1.text = "Excelente, bien hecho, has ganado:"+ "\n";
			//misonido = GetComponent<AudioSource>();
			misonido.enabled = true;


			Escritop.text=""+ puntaje;
		}
	}
	public void MostrarFracaso(){
		Escrito1 = GameObject.FindGameObjectWithTag ("Fra").GetComponent<Text> ();
		Escrito1.fontSize = 20;
		//Escritop= GameObject.FindGameObjectWithTag ("puntos1").GetComponent<Text> ();
		if (this.Ayuda == "Fracaso") {
			Escrito1.text = "Intentalo nuevamente ,¡Tu puedes hacerlo!";
			//misonido = GetComponent<AudioSource>();
			misonido.enabled = true;


			//Escritop.text=""+ puntaje;
		}
	}
	public void CerrarSonido(){
		this.misonido.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	

	}
}
