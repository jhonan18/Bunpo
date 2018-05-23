using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour {

    public static float bosshealth = 3;
    public static float astrohealth = 3;
    public static string astrofig = "niña 2";
    public static string bossfig = "boss 3";

    public void bossupdate(float bossh)
    {
        bosshealth = bossh;
    }
    public void astroupdate(float bossh)
    {
        astrohealth = bossh;
    }
    public void astrofigupdate(string astro)
    {
        astrofig = astro;
    }
    public void bossfigupdate(string boss)
    {
        bossfig=boss;
    }
    void Start () {
        astrofig = Persistencia.partida.personaje;

	}
    public string getastrofig()
    {
        return astrofig;
    }
    public string getbossfig()
    {
        return bossfig;
    }
    public float getbossh()
    {
        return bosshealth;
    }
    public float getastroh()
    {
        return astrohealth;
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }
    // Update is called once per frame
    void Update () {
		
	}
}
