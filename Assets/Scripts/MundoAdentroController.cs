using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MundoAdentroController : MonoBehaviour {

    public TextMeshProUGUI dinero;
    public Canvas ayuda;

	// Use this for initialization
	void Start () {
        dinero.text = Persistencia.partida.money.ToString();
        if (!Persistencia.partida.ayudaMinijuego)
        {
            ayuda.enabled = true;
            Persistencia.partida.ayudaMinijuego = true;
            Persistencia.save();
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void backToSpace()
	{
		Persistencia.casillaCuadriculaActual = 0;
        Persistencia.puntoActual = 0;
        Persistencia.save();
		SceneMgr.loadScene("Space Art");
	}
}
