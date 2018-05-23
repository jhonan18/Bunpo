using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class batallaController : MonoBehaviour {


    public Text cuadro1;
    public Text cuadro2;
    public Text cuadro3;
    
    public Text opcion1;
    public Text opcion2;
    public Text opcion3;

    public string respuesta;

    public int posLlenar;
    public bool listo;

    List<string> opcionesFalsas;

    int n = -1;
    int dif = 0;

    // Use this for initialization
    void Start () {

        listo = false;

        opcionesFalsas = new List<string>();
        opcionesFalsas.Add("llueve");
        opcionesFalsas.Add("come");
        opcionesFalsas.Add("negro");
        opcionesFalsas.Add("no");
        opcionesFalsas.Add("blanco");
        opcionesFalsas.Add("nieve");
        opcionesFalsas.Add("mueve");
        opcionesFalsas.Add("surge");
        opcionesFalsas.Add("vuelve");
        opcionesFalsas.Add("cae");
        opcionesFalsas.Add("rojo");
        opcionesFalsas.Add("parque");
        opcionesFalsas.Add("arbol");
        opcionesFalsas.Add("camino");
        opcionesFalsas.Add("trae");
        opcionesFalsas.Add("vive");
        opcionesFalsas.Add("pueblo");

        dif = 0;

        if (Persistencia.getMundoNum() != 0)
        {
            dif = Persistencia.partida.dificultad-1;
        }
        n = Random.Range(0, BDFrases.mundos[Persistencia.getMundoNum()].juegos[2].frases[dif].Count);


        List<string> faux = new List<string>(BDFrases.mundos[Persistencia.getMundoNum()].juegos[2].frases[dif][n].partes);

        string lineas = "________";
       
        int posLineas = Random.Range(0,3);

        posLlenar = posLineas;

        respuesta = faux[0] + faux[1] + faux[2];

        cuadro1.text = faux[0];
        cuadro2.text = faux[1];
        cuadro3.text = faux[2];

        string aux = "";

        if (posLineas == 0)
        {
            cuadro1.text = lineas;
            aux = faux[0];
        }
        else if (posLineas == 1)
        {
            cuadro2.text = lineas;
            aux = faux[1];
        }
        else
        {
            cuadro3.text = lineas;
            aux = faux[2];
        }


        int posRes = Random.Range(0, 3);
        if (posRes == 0)
        {
            opcion1.text = aux;
            opcion2.text = opcionesFalsas[Random.Range(0,17)];
            opcion3.text = opcionesFalsas[Random.Range(0, 17)];
        }
        else if (posRes == 1)
        {
            opcion2.text = aux;
            opcion1.text = opcionesFalsas[Random.Range(0, 17)];
            opcion3.text = opcionesFalsas[Random.Range(0, 17)];
        }
        else
        {
            opcion3.text = aux;
            opcion2.text = opcionesFalsas[Random.Range(0, 17)];
            opcion1.text = opcionesFalsas[Random.Range(0, 17)];
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
