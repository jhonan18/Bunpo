using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class palabraController : MonoBehaviour {

    public int numero;
    Color colorInicial;
    bool seleccionado;

    public EjercicioSeleccionController ESC;

	// Use this for initialization
	void Start () {
        colorInicial = GetComponent<Image>().color;
        seleccionado = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void seleccionar()
    {
        if (!seleccionado)
        {
            GetComponent<Image>().color = Color.green;
            seleccionado = true;
            ESC.añadir(numero);
        }
        else
        {
            GetComponent<Image>().color = colorInicial;
            seleccionado = false;
            ESC.remover(numero);
        }
    }

}
