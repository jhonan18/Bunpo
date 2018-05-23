using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompPoint : MonoBehaviour {

    public string escena;
    public int numero;
    public int nEjercicios;
    public bool puntoFinal;

    public Sprite vacio;

    // Use this for initialization
    void Start()
    {
        int mundoN = Persistencia.getMundoNum();
        
        if(Persistencia.partida.mundos[mundoN].puntos[numero].nEjercicios == 0)
        {
            Persistencia.partida.mundos[mundoN].puntos[numero].nEjercicios = nEjercicios;
            Persistencia.partida.mundos[mundoN].puntos[numero].puntosFaltantes = nEjercicios;
            Persistencia.partida.mundos[mundoN].puntos[numero].puntoFinal = puntoFinal;
        }
        actualizarColor();  
    }
	// Update is called once per frame
	void Update () {
		
	}

    public string getEscena()
    {
        return escena;
    }

    public void actualizarColor()
    {
        int nM = Persistencia.getMundoNum();
        if (!escena.Equals(""))
        {
            if (Persistencia.partida.mundos[nM].puntos[numero].completado)
            {
                GetComponent<SpriteRenderer>().color = Persistencia.basico;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Persistencia.oscuro;
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = vacio;
        }

        int j = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (nEjercicios - Persistencia.partida.mundos[nM].puntos[numero].puntosFaltantes > j)
            {
                transform.GetChild(i).transform.GetComponent<SpriteRenderer>().color = Persistencia.basico;
                j++;
            }
            else
            {
                transform.GetChild(i).transform.GetComponent<SpriteRenderer>().color = Persistencia.oscuro;
            }
            if (i >= nEjercicios)
            {
                transform.GetChild(i).transform.GetComponent<SpriteRenderer>().color = Persistencia.invisible;
            }
        }

    }

}
