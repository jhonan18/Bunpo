using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Diagnostics;

public class AyudaMgr : MonoBehaviour {

    Stopwatch stopwatch;
    Stopwatch stopwatchA;

    public Canvas victoria;
    public Canvas fracaso;
    public Canvas sencillo;
    public Canvas sujeto;
    public Canvas verbo;
    public Canvas predicado;
    public Canvas compleja;

    bool isOpen;
    bool ayudaisOpen;

    float tiempoMostrar;
    bool mostrado;

    // Use this for initialization
    void Start () {
        mostrado = false;
        isOpen = false;
        ayudaisOpen = false;
        if (Persistencia.partida.dificultad == 1)
        {
            tiempoMostrar = Dificultad.tiempoSAyuda1;
        }
        else if (Persistencia.partida.dificultad == 2)
        {
            tiempoMostrar = Dificultad.tiempoSAyuda2;
        }
        else
        {
            tiempoMostrar = Dificultad.tiempoSAyuda3;
        }

        stopwatch = new Stopwatch();
        stopwatchA = new Stopwatch();
        stopwatch.Start();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (!mostrado && stopwatch.Elapsed.Seconds > tiempoMostrar)
        {
            mostrado = true;
            stopwatch.Stop();
            mostrarAyuda();
        }
        if (ayudaisOpen && stopwatchA.Elapsed.Seconds > 2)
        {
            ayudaisOpen = false;
            fracaso.enabled = false;
            stopwatchA.Stop();
            stopwatchA.Reset();
            stopwatchA.Stop();
        }
	}

    public void mostrarAyuda()
    {
        int mundo = Persistencia.getMundoNum();
        if (!isOpen)
        {
            Time.timeScale = 0;
            if (mundo == 0)
            {
                sencillo.enabled = true;
            }
            else if (mundo == 1)
            {
                sujeto.enabled = true;
            }
            else if (mundo == 2)
            {
                verbo.enabled = true;
            }
            else if (mundo == 3)
            {
                predicado.enabled = true;
            }
            else if (mundo == 4)
            {
                compleja.enabled = true;
            }
            isOpen = true;
        }
        else
        {
            Time.timeScale = 1;
            if (mundo == 0)
            {
                sencillo.enabled = false;
            }
            else if (mundo == 1)
            {
                sujeto.enabled = false;
            }
            else if (mundo == 2)
            {
                verbo.enabled = false;
            }
            else if (mundo == 3)
            {
                predicado.enabled = false;
            }
            else if (mundo == 4)
            {
                compleja.enabled = false;
            }
            isOpen = false;
        }
    }

    public void cerrarAyuda()
    {
        int mundo = Persistencia.getMundoNum();
        Time.timeScale = 1;
        if (mundo == 0)
        {
            sencillo.enabled = false;
        }
        else if (mundo == 1)
        {
            sujeto.enabled = false;
        }
        else if (mundo == 2)
        {
            verbo.enabled = false;
        }
        else if (mundo == 3)
        {
            predicado.enabled = false;
        }
        else if (mundo == 4)
        {
            compleja.enabled = false;
        }
    }

    public void mostrarVictoria()
    {
        victoria.enabled = true;
    }

    public void mostrarDerrota()
    {
        fracaso.enabled = true;
        stopwatch.Stop();
        stopwatch.Reset();
        stopwatch.Start();
        stopwatchA.Start();
        ayudaisOpen = true;

    }
}
