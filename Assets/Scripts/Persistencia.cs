using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Persistencia {

    public static Partida partida = new Partida();
    public static string mundoActual;
    public static int puntoActual;
    public static int ejercicioActual;
    public static string miniJuegoActual;
    public static int contPuntos;
    public static int casillaCuadriculaActual;
    public static int casillaCuadriculaAnterior;
    public static Vector3 posicionPuntoActual;

    public static Color basico = new Color(1f,1f,1f,255f);
    public static Color oscuro = new Color(0.301f, 0.277f, 0.277f, 1f);
    public static Color invisible = new Color(1f, 1f, 1f, 0f);

    public static void save()
    {
        /*string filePath;
        string jsonString;
        filePath = Application.dataPath + "/Json/Partida.json";
        jsonString = JsonUtility.ToJson(partida);
        File.WriteAllText(filePath, jsonString);*/
        BinaryFormatter bf = new BinaryFormatter();
        //Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
        //Debug.Log(Application.persistentDataPath);
        FileStream file = File.Create(Application.persistentDataPath + "/partida.gd"); //you can call it anything you want
        bf.Serialize(file, Persistencia.partida);
        file.Close();
    }

    public static void load()
    {
        BDFrases.start();
        /*string filePath;
        string jsonString;
        filePath = Application.dataPath + "/Json/Partida.json";
        jsonString = File.ReadAllText(filePath);
        partida = JsonUtility.FromJson<Partida>(jsonString);
        BDFrases.start();*/
        if (File.Exists(Application.persistentDataPath + "/partida.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/partida.gd", FileMode.Open);
            Persistencia.partida = (Partida)bf.Deserialize(file);
            file.Close();
        }
    }

    public static int getMundoNum()
    {
        int n = 0;
        foreach (Mundo m in partida.mundos)
        {
            if (m.nombre.Equals(mundoActual, System.StringComparison.InvariantCultureIgnoreCase))
            {
                return n;
            }
            n++;
        }
        return -1;
    }

    

}
