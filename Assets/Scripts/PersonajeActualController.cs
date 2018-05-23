using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersonajeActualController : MonoBehaviour {

    public PanelPersonajeController panelPrincipal;
    public TextMeshProUGUI dinero;
    public TextMeshProUGUI valor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPersonaje()
    {
        if (panelPrincipal.GetComponent<Image>().sprite.name.Equals("extraterrestre 1"))
        {
            if (Persistencia.partida.alien1)
            {
                this.GetComponent<Image>().sprite = panelPrincipal.GetComponent<Image>().sprite;
                Persistencia.partida.personaje = panelPrincipal.GetComponent<Image>().sprite.name;
            }
            else if (Persistencia.partida.money >= Persistencia.partida.valorA1)
            {
                Persistencia.partida.alien1 = true;
                valor.text = "Adquirido";
                Persistencia.partida.money -= Persistencia.partida.valorA1;
                dinero.text = Persistencia.partida.money.ToString();
                this.GetComponent<Image>().sprite = panelPrincipal.GetComponent<Image>().sprite;
                Persistencia.partida.personaje = panelPrincipal.GetComponent<Image>().sprite.name;
            }
        }else if (panelPrincipal.GetComponent<Image>().sprite.name.Equals("extraterrestre 2"))
        {
            if (Persistencia.partida.alien2)
            {
                this.GetComponent<Image>().sprite = panelPrincipal.GetComponent<Image>().sprite;
                Persistencia.partida.personaje = panelPrincipal.GetComponent<Image>().sprite.name;
            }
            else if (Persistencia.partida.money >= Persistencia.partida.valorA2)
            {
                Persistencia.partida.alien2 = true;
                valor.text = "Adquirido";
                Persistencia.partida.money -= Persistencia.partida.valorA2;
                dinero.text = Persistencia.partida.money.ToString();
                this.GetComponent<Image>().sprite = panelPrincipal.GetComponent<Image>().sprite;
                Persistencia.partida.personaje = panelPrincipal.GetComponent<Image>().sprite.name;
            }
        }
        else
        {
            this.GetComponent<Image>().sprite = panelPrincipal.GetComponent<Image>().sprite;
            Persistencia.partida.personaje = panelPrincipal.GetComponent<Image>().sprite.name;
            valor.text = "";
        }
        
    }

    public void setPersonaje(Sprite per)
    {
        if (per != null)
        {
            this.GetComponent<Image>().sprite = per;
        }
    }

}
