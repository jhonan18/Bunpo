using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Dificultad{

    public static int numeroEjercicios = 4;
    public static float unoADos = 4;
    public static float dosAUno = 3;
    public static float dosAtres = 4.2f;
    public static float tresADos = 3;
    public static float[] tiempoSMinimo = new float[] {6, 8, 12};
    public static float[] tiempoSMaximo = new float[] {20, 28, 40};
    public static int maximoErrores = 3;
    public static int minimoAyudas = 1;
    public static int maximoAyudas = 3;

    public static int maximoIntentos1 = 3;
    public static int maximoIntentos2 = 2;
    public static int maximoIntentos3 = 2;
    public static float tiempoSAyuda1 = 10;
    public static float tiempoSAyuda2 = 15;
    public static float tiempoSAyuda3 = 20; 

    private static float porcentajeCompletas = 0.5f;
    private static float porcentajeErrores = 0.3f;
    private static float porcentajeAyudas = 0.13f;
    private static float porcentajeTiempo = 0.07f;


    public static float calcular(bool canChange)
    {
        float valorCompletas;
        float valorErrores;
        float valorAyudas;
        float valorTiempo;

        float promErrores = 0;
        float promAyudas = 0;
        float promCompletados = 0;
        float promTiempo = 0;
        
        foreach (Ejercicio e in Persistencia.partida.ejercicios)
        {
            if (e.nErrores > maximoErrores)
            {
                promErrores += maximoErrores;
            }
            else
            {
                promErrores += e.nErrores;
            }

            if (e.nAyudas > maximoAyudas)
            {
                promAyudas += maximoAyudas;
            }
            else
            {
                promAyudas += e.nAyudas;
            }

            if (e.tiempo > tiempoSMaximo[Persistencia.partida.dificultad - 1])
            {
                promTiempo += tiempoSMaximo[Persistencia.partida.dificultad - 1];
            }
            else
            {
                promTiempo += e.tiempo;
            }

            if (e.completado)
            {
                promCompletados += 1;
            }
        }
        promErrores = promErrores / numeroEjercicios;
        promAyudas = promAyudas / numeroEjercicios;
        promTiempo = promTiempo / numeroEjercicios;
        promCompletados = promCompletados / numeroEjercicios;

        //completas

        valorCompletas = promCompletados * 5 * porcentajeCompletas;

        //errores

        valorErrores = (3 - promErrores) * (5 / 3) * porcentajeErrores;

        //ayudas

        if (promAyudas <= 1)
        {
            promAyudas = 0;
        }
        else
        {
            promAyudas--;
        }

        valorAyudas = (2 - promAyudas) * (5 / 2) * porcentajeAyudas;

        //tiempo

        if (promTiempo <= tiempoSMinimo[Persistencia.partida.dificultad - 1])
        {
            promTiempo = 0;
        }
        else
        {
            promTiempo -= tiempoSMinimo[Persistencia.partida.dificultad - 1];
        }

        valorTiempo = (tiempoSMaximo[Persistencia.partida.dificultad - 1] - promTiempo) * (5 / tiempoSMaximo[Persistencia.partida.dificultad - 1]) * porcentajeTiempo;

        //validacion

        float total = valorCompletas + valorErrores + valorAyudas + valorTiempo;
        

        if (canChange && Persistencia.partida.ejercicios.Count == numeroEjercicios)
        {
            if (Persistencia.partida.dificultad == 1)
            {
                if (total >= unoADos)
                {
                    Persistencia.partida.dificultad = 2;
                }
            }
            else if (Persistencia.partida.dificultad == 2)
            {
                if (total >= dosAtres)
                {
                    Persistencia.partida.dificultad = 3;
                }
                else if (total < dosAUno)
                {
                    Persistencia.partida.dificultad = 1;
                }
            }
            else if (Persistencia.partida.dificultad == 3)
            {
                if (total < tresADos)
                {
                    Persistencia.partida.dificultad = 2;
                }
            }
            
        }
        return total;
        
    }
}
