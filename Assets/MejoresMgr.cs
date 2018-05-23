using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class MejoresMgr : MonoBehaviour {

    public TextMeshProUGUI nombre1;
    public TextMeshProUGUI nombre2;
    public TextMeshProUGUI nombre3;
    public TextMeshProUGUI nombre4;
    public TextMeshProUGUI nombre5;
    public TextMeshProUGUI nombre6;
    public TextMeshProUGUI nombre7;
    public TextMeshProUGUI nombre8;
    public TextMeshProUGUI nombre9;
    public TextMeshProUGUI nombre10;

    public TextMeshProUGUI puntos1;
    public TextMeshProUGUI puntos2;
    public TextMeshProUGUI puntos3;
    public TextMeshProUGUI puntos4;
    public TextMeshProUGUI puntos5;
    public TextMeshProUGUI puntos6;
    public TextMeshProUGUI puntos7;
    public TextMeshProUGUI puntos8;
    public TextMeshProUGUI puntos9;
    public TextMeshProUGUI puntos10;

    public TextMeshProUGUI miPuntaje;

    // Use this for initialization
    void Start () {
        miPuntaje.text = System.Math.Round(Persistencia.partida.puntaje,2).ToString();
        llenarTabla();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void enviarDatos()
    {
        Persistencia.load();
        string filePath;
        string jsonString;
        filePath = Application.persistentDataPath + "/partida.gd";
        jsonString = File.ReadAllText(filePath);

        Persistencia.save();
        //Debug.Log(Persistencia.partida.idEstudiante);
        DataBaseMgr.actualizarEstudiante(Persistencia.partida.idEstudiante, jsonString, Persistencia.partida.puntaje, 
            Persistencia.partida.oner, Persistencia.partida.odif, Persistencia.partida.sner, Persistencia.partida.sdif, Persistencia.partida.vner, Persistencia.partida.vdif,
            Persistencia.partida.pner, Persistencia.partida.pdif, Persistencia.partida.cner, Persistencia.partida.cdif);

        llenarTabla();
    }

    public void llenarTabla()
    {
        List<List<string>> tops = DataBaseMgr.getTop(Persistencia.partida.idCurso);

        try
        {

            if (tops.Count / 2 >= 1)
            {
                nombre1.text = tops[0][0];
                puntos1.text = System.Math.Round(float.Parse(tops[0][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 2)
            {
                nombre2.text = tops[1][0];
                puntos2.text = System.Math.Round(float.Parse(tops[1][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 3)
            {
                nombre3.text = tops[2][0];
                puntos3.text = System.Math.Round(float.Parse(tops[2][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 4)
            {
                nombre4.text = tops[3][0];
                puntos4.text = System.Math.Round(float.Parse(tops[3][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 5)
            {
                nombre5.text = tops[4][0];
                puntos5.text = System.Math.Round(float.Parse(tops[4][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 6)
            {
                nombre6.text = tops[5][0];
                puntos6.text = System.Math.Round(float.Parse(tops[5][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 7)
            {
                nombre7.text = tops[6][0];
                puntos7.text = System.Math.Round(float.Parse(tops[6][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 8)
            {
                nombre8.text = tops[7][0];
                puntos8.text = System.Math.Round(float.Parse(tops[7][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 9)
            {
                nombre9.text = tops[8][0];
                puntos9.text = System.Math.Round(float.Parse(tops[8][1]), 2).ToString();
            }
            if (tops.Count / 2 >= 10)
            {
                nombre10.text = tops[9][0];
                puntos10.text = System.Math.Round(float.Parse(tops[9][1]), 2).ToString();
            }
        }
        catch (System.Exception e)
        {
            e.ToString();
        }
    }
}
