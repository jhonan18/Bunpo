using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeleccionPersonajeController : MonoBehaviour {

    string categoria = "niña";

    public PanelPersonajeController pp;
    public PanelPersonajeController pd;
    public PanelPersonajeController pi;
    public PersonajeActualController pa;
    public TextMeshProUGUI dinero;
    public TextMeshProUGUI valor;

    // Use this for initialization
    void Start () {
        Persistencia.load();
        pa.setPersonaje(getPersonajeActual());
        notificarCategoria();
        asignar();
        dinero.text = Persistencia.partida.money.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	                                
	}

    void notificarCategoria()
    {
        pp.setCategoria(categoria);
        pd.setCategoria(categoria);
        pi.setCategoria(categoria);
    }

    public void setCategoria(string nC)
    {
        if (!categoria.Equals(nC))
        {
            categoria = nC;
            notificarCategoria();
            asignar();
        }
        
    }

    void asignar()
    {
        if (categoria.Equals("niña"))
        {
            pp.asignar("niña 1");
            pd.asignar("niña 2");
            pi.asignar("niña 3");

            valor.text = "";

        }else if (categoria.Equals("niño"))
        {
            pp.asignar("niño 1");
            pd.asignar("niño 2");
            pi.asignar("niño 3");
            
            valor.text = "";

        } else if (categoria.Equals("extraterrestre"))
        {
            pp.asignar("extraterrestre 1");
            pd.asignar("extraterrestre 2");
            pi.asignar("extraterrestre 2");

            if (Persistencia.partida.alien1)
            {
                valor.text = "Adquirido";
            }
            else
            {
                valor.text = Persistencia.partida.valorA1.ToString();
            }
        }
    }

    Sprite getPersonajeActual()
    {
        if (Persistencia.partida.personaje.Equals("niña 1"))
        {
            return pp.niña1;
        }
        else if (Persistencia.partida.personaje.Equals("niña 2"))
        {
            return pp.niña2;
        }
        else if (Persistencia.partida.personaje.Equals("niña 3"))
        {
            return pp.niña3;
        }
        else if (Persistencia.partida.personaje.Equals("niño 1"))
        {
            return pp.niño1;
        }
        else if (Persistencia.partida.personaje.Equals("niño 2"))
        {
            return pp.niño2;
        }
        else if (Persistencia.partida.personaje.Equals("niño 3"))
        {
            return pp.niño3;
        }
        else if (Persistencia.partida.personaje.Equals("extraterrestre 1"))
        {
            return pp.alien1;
        }
        else if (Persistencia.partida.personaje.Equals("extraterrestre 2"))
        {
            return pp.alien2;
        }
        return null;
    }

    public void cambioValor()
    {
        if (categoria.Equals("extraterrestre"))
        {
            if (pp.GetComponent<Image>().sprite.name.Equals("extraterrestre 1"))
            {
                if (Persistencia.partida.alien1)
                {
                    valor.text = "Adquirido";
                }
                else
                {
                    valor.text = Persistencia.partida.valorA1.ToString();
                }
            }
            else
            {
                if (Persistencia.partida.alien2)
                {
                    valor.text = "Adquirido";
                }
                else
                {
                    valor.text = Persistencia.partida.valorA2.ToString();
                }
            }
        }
        else
        {
            valor.text = "";
        }
    }

    public void seguir()
    {
        if (!Persistencia.partida.personaje.Equals(""))
        {
            Persistencia.save();
            SceneMgr.loadScene("Space Art");
        }
    }

}
