using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class VerificarJson : MonoBehaviour {

    public Canvas con;
    public Canvas ng;
	

    public void continuar()
    {

        if (File.Exists(Application.persistentDataPath + "/partida.gd"))
        {
            Persistencia.load();
            SceneManager.LoadScene("Space Art");
        }
        else
        {
            con.enabled = true;
        }
    }

    public void NuevaPartida()
    {
        if (File.Exists(Application.persistentDataPath + "/partida.gd"))
        {
            ng.enabled = true;
        }
        else
        {
            SceneManager.LoadScene("Menú Datos");
        }
    }

    public void cerrarNPG()
    {
        con.enabled = false;
    }

    public void listoNG()
    {
        File.Delete(Application.persistentDataPath + "/partida.gd");
        SceneManager.LoadScene("Menú Datos");
    }

    public void cancelNG()
    {
        ng.enabled = false;
    }


}
