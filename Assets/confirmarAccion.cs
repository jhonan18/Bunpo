using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class confirmarAccion : MonoBehaviour {

	// Use this for initialization
	public Text text1;
    public Text text2;
    public Text text3;
    public batallaController bc;
    public Button boton;
    public sc1 astro;
    public sc1 boss;
    public sc1 fondo;
    public GameObject bulletPrefab;
    public GameObject bulletPrefabboss;
    public Image imagenastronormal;
    public Image imagenbossnormal;
    public GameObject Pasodatos;
    public scri datos;
    public string astrofig = "";
    public string bossfig = "";
    public MiniJuegoController mini;

    private void Start()
    {
        boton.onClick.AddListener(confirmar);
    }
    public void confirmar()
    {
        Pasodatos = GameObject.Find("PasoDatos");
        datos = Pasodatos.GetComponent<scri>();

        if(datos.getbossh()<= 0)
        {
            mini.correcto();
        }

        astrofig = datos.getastrofig();
        bossfig = datos.getbossfig();



        if (bc.respuesta.Equals(text1.text+text2.text+text3.text))
        {
            imagenastronormal.sprite = Resources.Load<Sprite>("Sprites/" + astrofig + " atacando");
            Vector3 offset =transform.rotation* new Vector3(117f,0,0);
            Instantiate(bulletPrefab, astro.holi().position + offset, astro.holi().rotation, fondo.holi());
            bc.listo = true;
        }
        else
        {
            imagenbossnormal.sprite = Resources.Load<Sprite>("Sprites/" + bossfig + " atacando");
            Vector3 offset =transform.rotation * new Vector3(-175f, 0, 0);
            Instantiate(bulletPrefabboss, boss.holi().position + offset, boss.holi().rotation,fondo.holi());
            bc.listo = true;
        }
    }
}
