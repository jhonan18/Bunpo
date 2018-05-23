using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosController : MonoBehaviour {

    public Toggle niño;
    public Toggle niña;
    public InputField nombre;
    public InputField edad;
    public InputField alias;
    public InputField contraseña;
    public Canvas mensaje;

    // Use this for initialization
    void Start () {
        //Add listener for when the state of the Toggle changes, to take action
        niño.onValueChanged.AddListener(delegate {
            niñoChanged();
        });
        
        //Add listener for when the state of the Toggle changes, to take action
        niña.onValueChanged.AddListener(delegate {
            niñaChanged();
        });
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void niñoChanged()
    {
        if (niño.isOn)
        {
            niña.isOn = false;
        }
    }

    void niñaChanged()
    {
        if (niña.isOn)
        {
            niño.isOn = false;
        }
    }

    public void listo()
    {
        if ((niño.isOn || niña.isOn) && !nombre.text.Equals("") && !edad.text.Equals("") && !alias.text.Equals("") && !contraseña.text.Equals(""))
        {
            Persistencia.partida.nombre = nombre.text;
            Persistencia.partida.edad = int.Parse(edad.text);
            Persistencia.partida.alias = alias.text;
            Persistencia.partida.contraseña = contraseña.text;
            if (niño.isOn)
            {
                Persistencia.partida.genero = "niño";
            }
            else
            {
                Persistencia.partida.genero = "niña";
            }
            Persistencia.save();
            SceneMgr.loadScene("SeleccionPersonaje");
        }
        else
        {
            mensaje.enabled = true;
        }
    }

    public void sincronizar()
    {
        if ((niño.isOn || niña.isOn) && !nombre.text.Equals("") && !edad.text.Equals("") && !alias.text.Equals("") && !contraseña.text.Equals(""))
        {
            Persistencia.partida.nombre = nombre.text;
            Persistencia.partida.edad = int.Parse(edad.text);
            Persistencia.partida.alias = alias.text;
            Persistencia.partida.contraseña = contraseña.text;
            if (niño.isOn)
            {
                Persistencia.partida.genero = "niño";
            }
            else
            {
                Persistencia.partida.genero = "niña";
            }
            Persistencia.save();
            SceneMgr.loadScene("Sincronizacion");
        }
        else
        {
            mensaje.enabled = true;
        }
    }
    

    public void cerrarMensaje()
    {
        mensaje.enabled = false;
    }

}
