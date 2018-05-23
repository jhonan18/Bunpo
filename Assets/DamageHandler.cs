using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageHandler : MonoBehaviour {
    public Image boss;
   public Image astro;
    public float health = 1;
    public float maxhealth = 1;
    public Image BossHealth;
    public Image AstroHealth;
    public float tiempo = 0f;
    public GameObject button;
    public scri datos;
    public GameObject Pasodatos;
    public string astrofig = "";
    public string bossfig = "";
    public MiniJuegoController mini;

    void Start()
    {
        Pasodatos = GameObject.Find("PasoDatos");
        datos = Pasodatos.GetComponent<scri>();
        astrofig=datos.getastrofig();
        bossfig = datos.getbossfig();
        try
        {
            this.astro.sprite= Resources.Load<Sprite>("Sprites/"+astrofig+" stand");
            this.boss.sprite= Resources.Load<Sprite>("Sprites/"+bossfig + " stand");
        }
        catch (System.Exception e)
        {
            e.ToString();
        }
        if (this.transform.name == "boss")
        {
            
            this.health = datos.getbossh();
            
            BossHealth.transform.localScale = new Vector2(health / maxhealth, 1);
        }
        if (this.transform.name == "astro")
        {
            this.health = datos.getastroh();
            AstroHealth.transform.localScale = new Vector2(health / maxhealth, 1);
        }
    }
    void OnTriggerEnter2D()
    {
        health--;
        if (this.transform.name == "boss")
        {
        
            boss.sprite = Resources.Load<Sprite>("Sprites/"+bossfig+" sufriendo");
            BossHealth.transform.localScale = new Vector2(health / maxhealth, 1);
            datos.bossupdate(health);
            Destroy(button);

        }
        if (this.transform.name == "astro")
        {
          
            astro.sprite = Resources.Load<Sprite>("Sprites/" + astrofig + " sufriendo");
            AstroHealth.transform.localScale = new Vector2(health / maxhealth, 1);
            datos.astroupdate(health);
            Destroy(button);
        }
       
        

    }
    void Update()
    {
   
        if (health<=0)
        {
            if (this.transform.name == "boss")
            {
                scri.bosshealth = 3;
                scri.astrohealth = 3;
                mini.correcto();
            }else if (this.transform.name == "astro")
            {
                scri.bosshealth = 3;
                scri.astrohealth = 3;
                SceneMgr.loadScene(Persistencia.mundoActual);
            }
            Die();
        }    
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
