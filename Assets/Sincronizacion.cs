using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sincronizacion : MonoBehaviour {

    public Dropdown colegio;
    public Dropdown curso;
    public Canvas mensaje;

    List<int> keys = new List<int>();
    List<string> values = new List<string>();
    List<int> keysC = new List<int>();
    List<string> valuesC = new List<string>();

    // Use this for initialization
    void Start () {

        colegio.ClearOptions();
        curso.ClearOptions();
        keys.Clear();
        values.Clear();
        keysC.Clear();
        valuesC.Clear();

        Dictionary<int, string> colegios = DataBaseMgr.getSchools();
        foreach (KeyValuePair<int, string> pair in colegios)
        {
            keys.Add(pair.Key);
            values.Add(pair.Value);
        }

        keys.RemoveAt(0);
        values.RemoveAt(0);

        colegio.AddOptions(values);
        cargarCursos();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void cargarCursos()
    {
        curso.ClearOptions();
        keysC.Clear();
        valuesC.Clear();

        if (keys.Count>0)
        {
            Dictionary<int, string> cursos = DataBaseMgr.getCourses(keys[colegio.value]);
            foreach (KeyValuePair<int, string> pair in cursos)
            {
                keysC.Add(pair.Key);
                valuesC.Add(pair.Value);
            }

            curso.AddOptions(valuesC);
        }
    }

    public void sinColegio()
    {
        Persistencia.partida.nColegio = "BunpoGeneral";
        Persistencia.partida.nCurso = "CursoGeneral";
        Persistencia.partida.idColegio = 17;
        Persistencia.partida.idCurso = 1;

        Persistencia.save();

        DataBaseMgr.nuevoEstudiante(Persistencia.partida.nombre, Persistencia.partida.idCurso, Persistencia.partida.alias, Persistencia.partida.contraseña);
        Persistencia.partida.idEstudiante = DataBaseMgr.getIdStudentAlias(Persistencia.partida.alias);
        Persistencia.save();
        SceneManager.LoadScene("SeleccionPersonaje");

    }

    public void listo()
    {
        if (keys.Count <= 0 || keysC.Count <= 0)
        {
            mensaje.enabled = true;
        }
        else
        {
            Persistencia.partida.nColegio = colegio.captionText.ToString();
            Persistencia.partida.nCurso = curso.captionText.ToString();
            Persistencia.partida.idColegio = keys[colegio.value];
            Persistencia.partida.idCurso = keysC[curso.value];

            

            DataBaseMgr.nuevoEstudiante(Persistencia.partida.nombre, Persistencia.partida.idCurso, Persistencia.partida.alias, Persistencia.partida.contraseña);
            Persistencia.partida.idEstudiante = DataBaseMgr.getIdStudentAlias(Persistencia.partida.alias);
            Persistencia.save();
            SceneManager.LoadScene("SeleccionPersonaje");
        }
    }

    public void cerrarMensaje()
    {
        mensaje.enabled = false;
    }

}
