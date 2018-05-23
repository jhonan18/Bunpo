using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class EjercicioSeleccionController : MonoBehaviour {

    public GameObject panel1;
    public GameObject panel2;

    public TextMeshProUGUI enunciado;

    int diferencia = 0;
    List<int> respuesta;
    int nfrase;
    public List<string> frase;
    public List<int> res;
    int dif;

    public MiniJuegoController mini;

    public List<Ejercicio> frases;

    // Use this for initialization
    void Start()
    {
        respuesta = new List<int>();

        //llena los botones con las palabras

        dif = 0;

        if (Persistencia.getMundoNum() != 0)
        {
            dif = Persistencia.partida.dificultad - 1;
        }
        
        nfrase = UnityEngine.Random.Range(0,BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif].Count);

        int tamañoMaximo = 30;
        int tamañoActual = 0;
        int punto = 0;
        bool sobrecarga = false;



        for (int i = 0; i < panel1.transform.childCount; i++)
        {
            punto = i;
            if (tamañoMaximo < tamañoActual + BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes[i].Length)
            {
                sobrecarga = true;
                break;
            }
            panel1.transform.GetChild(i).GetComponentInChildren<Text>().text = BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes[i];
            
            tamañoActual += BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes[i].Length;
            
            if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes.Count <= i + 1) {
                break;
            }
            
        }
        
        if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes.Count > 10 || sobrecarga)
        {
            for (int i = 0; i < panel2.transform.childCount; i++)
            {
                if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes.Count <= punto + i)
                {
                    break;
                }
                panel2.transform.GetChild(i).GetComponentInChildren<Text>().text = BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].partes[punto + i];
            }
        }
        
        if (sobrecarga)
        {
            diferencia = 10 - punto;
        }

        // elimina los botones sobrantes
        int desde = 10;
        for (int i = 0; i < panel1.transform.childCount; i++)
        {
            if (panel1.transform.GetChild(i).GetComponentInChildren<Text>().text == "")
            {
                desde = i;
                break;
            }
        }
        int countChild = panel1.transform.childCount;
        for (int i = desde; i < countChild; i++)
        {
            panel1.transform.GetChild(desde).SetParent(this.transform.parent.parent.parent);
        }

        desde = 10;
        for (int i = 0; i < panel2.transform.childCount; i++)
        {
            if (panel2.transform.GetChild(i).GetComponentInChildren<Text>().text == "")
            {
                desde = i;
                break;
            }
        }
        countChild = panel2.transform.childCount;
        for (int i = desde; i < countChild; i++)
        {
            panel2.transform.GetChild(desde).SetParent(this.transform.parent.parent.parent);
        }

    }

    // Update is called once per frame
    void Update() {

    }

    int corregirRespuesta(int r)
    {
        if (r >= 10)
        {
            return r - diferencia;
        }
        else
        {
            return r;
        }
    }

    public void añadir(int r)
    {
        respuesta.Add(corregirRespuesta(r));
        respuesta.Sort();
        /*String imp = "";
        foreach (int i in respuesta)
        {
            imp += i + " ";
        }
        Debug.Log(imp);*/
    }

    public void remover(int r)
    {
        respuesta.Remove(corregirRespuesta(r));
        /*String imp = "";
        foreach (int i in respuesta)
        {
            imp += i+" ";
        }
        Debug.Log(imp);
        /*int pos = 0;
        foreach (int i in respuesta)
        {
            if (i == n)
            {
                respuesta.RemoveAt(pos);
              
                break;
            }
            pos++;
        }*/
    }

    public void verificar()
    {
        bool igual = true;
        if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].sujeto.Count == respuesta.Count)
        {
            for (int i = 0; i < respuesta.Count; i++)
            {
                if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[3].frases[dif][nfrase].sujeto[i] != respuesta[i])
                {
                    igual = false;
                    break;
                }
            }
        }
        else
        {
            igual = false;
        }

        if (igual)
        {
            mini.correcto();
        }
        else
        {
            mini.error();
        }
    }


}
