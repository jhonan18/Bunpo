using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;

public class MiniJuegoController : MonoBehaviour {
    
    static int nAyudas;
    static int nErrores;
    static Stopwatch stopwatch;
    public AyudaMgr ayudamgr;

    // Use this for initialization
    void Start () {
        nAyudas = 0;
        nErrores = 0;
        stopwatch = new Stopwatch();
        stopwatch.Start();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void addAyuda()
    {
        nAyudas++;
    }
    
	public void correcto()
	{
        stopwatch.Stop();
        ayudamgr.mostrarVictoria();
		int mundoNum = Persistencia.getMundoNum();

		if (Persistencia.partida.ejercicios.Count >= Dificultad.numeroEjercicios)
		{
            //UnityEngine.Debug.Log("Removido");
			Persistencia.partida.ejercicios.RemoveAt(0);
		}

		Ejercicio e = new Ejercicio();
		e.completado = true;
		e.nErrores = nErrores;
		e.nAyudas = nAyudas;
		e.tiempo = (float)System.Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
		Persistencia.partida.ejercicios.Add(e);

        float puntajeGeneral = Dificultad.calcular(false);

		Persistencia.contPuntos += 1;

		if (Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes > Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].nEjercicios - Persistencia.contPuntos)
		{
			if (Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes >= Persistencia.contPuntos)
			{
				Persistencia.partida.money += Persistencia.contPuntos;
				Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes -= Persistencia.contPuntos;

                if (puntajeGeneral != -1)
                {
                    Persistencia.partida.puntaje += puntajeGeneral;
                }
			}
			else
			{
				Persistencia.partida.money += Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes;
				Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes = 0;

                if (puntajeGeneral != -1)
                {
                    Persistencia.partida.puntaje += puntajeGeneral;
                }
            }
		}
		if (Persistencia.contPuntos > Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntaje)
		{
			Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntaje = Persistencia.contPuntos;
		}
		if (Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntosFaltantes <= 0)
        {
            //UnityEngine.Debug.Log("Entro " + Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntoFinal);
            Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].completado = true;
            Dificultad.calcular(true);
            if (Persistencia.partida.mundos[mundoNum].puntos[Persistencia.puntoActual].puntoFinal)
            {
	            Persistencia.partida.mundos[mundoNum].completado = true;
                Persistencia.partida.ejercicios.Clear();
            }
		}

		if (Persistencia.partida.mundos [mundoNum].puntos [Persistencia.puntoActual].nEjercicios > Persistencia.ejercicioActual) {
			Persistencia.ejercicioActual += 1;
            Persistencia.save();
			SceneMgr.loadScene (Persistencia.miniJuegoActual);
		}
        Persistencia.save();
		SceneMgr.loadScene(Persistencia.mundoActual);
	}

    public void error()
    {
        ayudamgr.mostrarDerrota();
        nErrores++;
        if (nErrores < Dificultad.maximoErrores)
        {
            //mostrar ventana vuelve a intentar

        }
        else
        {
            stopwatch.Stop();

            if (Persistencia.partida.ejercicios.Count >= Dificultad.numeroEjercicios)
            {
                Persistencia.partida.ejercicios.RemoveAt(0);
            }

            Ejercicio e = new Ejercicio();
            e.completado = false;
            e.nErrores = nErrores;
            e.nAyudas = nAyudas;
            e.tiempo = (float)System.Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
            Persistencia.partida.ejercicios.Add(e);

            ///////////////////////
            //Persistencia.contPuntos += 1;

            Dificultad.calcular(true);

            Persistencia.save();
            SceneMgr.loadScene(Persistencia.mundoActual);
        }
    }

    /*public static void error()
    {
        foreach (Mundo m in Persistencia.partida.mundos)
        {
            if (m.nombre.Equals(Persistencia.mundoActual, System.StringComparison.InvariantCultureIgnoreCase))
            {
                if (m.puntos[Persistencia.puntoActual].nEjercicios > Persistencia.ejercicioActual)
                {
                    Persistencia.ejercicioActual += 1;
                    SceneMgr.loadScene(Persistencia.miniJuegoActual);
                }
                else
                {
                    if (m.puntos[Persistencia.puntoActual].puntosFaltantes > m.puntos[Persistencia.puntoActual].nEjercicios - Persistencia.contPuntos)
                    {
                        if (m.puntos[Persistencia.puntoActual].puntosFaltantes >= Persistencia.contPuntos)
                        {
                            Persistencia.partida.money += Persistencia.contPuntos;
                            Persistencia.partida.puntaje += Persistencia.contPuntos; //Cambiar
                            m.puntos[Persistencia.puntoActual].puntosFaltantes -= Persistencia.contPuntos;
                        }
                        else
                        {
                            Persistencia.partida.money += m.puntos[Persistencia.puntoActual].puntosFaltantes;
                            Persistencia.partida.puntaje += m.puntos[Persistencia.puntoActual].puntosFaltantes; //Cambiar
                            m.puntos[Persistencia.puntoActual].puntosFaltantes = 0;
                        }
                    }
                    if (Persistencia.contPuntos > m.puntos[Persistencia.puntoActual].puntaje)
                    {
                        m.puntos[Persistencia.puntoActual].puntaje = Persistencia.contPuntos;
                    }
                    if (m.puntos[Persistencia.puntoActual].puntosFaltantes <= 0)
                    {
                        m.puntos[Persistencia.puntoActual].completado = true;
                    }
                    if (m.puntos[Persistencia.puntoActual].puntoFinal)
                    {
                        m.completado = true;
                    }
                    Persistencia.save();
                    SceneMgr.loadScene(Persistencia.mundoActual);
                }


                //Persistencia.partida.ejercicios
                if (Persistencia.partida.ejercicios.Count >= Dificultad.numeroEjercicios)
                {
                    Persistencia.partida.ejercicios.RemoveAt(0);
                }

                Ejercicio e = new Ejercicio();
                e.completado = false;
                e.nErrores = 1;
                e.nAyudas = 1;
                e.tiempo = 10;
                Persistencia.partida.ejercicios.Add(e);
                m.completado = true;
                break;
            }
        }
    }*/

}
