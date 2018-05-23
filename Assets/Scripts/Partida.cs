using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Partida {

    public string personaje;
    public string nombre;
    public int edad;
    public string alias;
    public string contraseña;
    public string nColegio;
    public string nCurso;
    public int idColegio;
    public int idCurso;
    public int idEstudiante;
    public string genero;
    public int dificultad;
    public int money;
    public bool alien1;
    public bool alien2;
    public int valorA1;
    public int valorA2;

    public int oner;
    public int odif;
    public int sner;
    public int sdif;
    public int vner;
    public int vdif;
    public int pner;
    public int pdif;
    public int cner;
    public int cdif;

    public float puntaje;

    public List<Mundo> mundos;
    public List<Ejercicio> ejercicios;

    public bool ayudaEspacio;
    public bool ayudaMinijuego;

    public Partida() {
        mundos = new List<Mundo>();
        mundos.Add(new Mundo("oracion"));
        mundos.Add(new Mundo("sujeto"));
        mundos.Add(new Mundo("verbo"));
        mundos.Add(new Mundo("predicado"));
        mundos.Add(new Mundo("complejo"));

        ejercicios = new List<Ejercicio>();

        dificultad = 1;

        money = 0;
        puntaje = 0;
        alien1 = false;
        alien2 = false;
        valorA1 = 5;
        valorA2 = 8;
        personaje = "";
        nombre = "";
        alias = "";
        contraseña = "";
        nColegio = "";
        nCurso = "";
        genero = "";

        ayudaEspacio = false;
        ayudaMinijuego = true;



        oner = 1;
        odif = 1;
        sner = 1;
        sdif = 1;
        vner = 1;
        vdif = 1;
        pner = 1;
        pdif = 1;
        cner = 1;
        cdif = 1;
}


    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}, {3}", nombre, edad, genero, personaje);
    }
}


[System.Serializable]
public class Mundo {

    public string nombre;
    public List<PuntoControl> puntos;
    public bool completado;

    public Mundo(string nNombre)
    {
        nombre = nNombre;
        puntos = new List<PuntoControl>();
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        puntos.Add(new PuntoControl());
        completado = false;
    }

}

[System.Serializable]
public class PuntoControl
{
    public bool completado;
    public int puntaje;
    public int puntosFaltantes;
    public int nEjercicios;
    public bool puntoFinal;

    public PuntoControl()
    {
        completado = false;
        puntaje = 0;;
    }

}

[System.Serializable]
public class Ejercicio
{
    public float tiempo;
    public bool completado;
    public int nErrores;
    public int nAyudas;

    public Ejercicio()
    {
        completado = false;
        tiempo = 0;
        nErrores = 0;
        nAyudas = 0;
    }

}
