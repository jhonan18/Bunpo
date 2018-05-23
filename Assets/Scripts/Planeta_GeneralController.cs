using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planeta_GeneralController : MonoBehaviour {

    public CSpace cSpace;
    public CoheteController coheteController;
    public string escena;
    public Canvas ayuda;

    // Use this for initialization
    void Start()
    {
        int i = 0;
        foreach (Mundo m in Persistencia.partida.mundos)
        {
            if (m.nombre.Equals(escena, System.StringComparison.InvariantCultureIgnoreCase))
            {
                if (i == 0)
                {
                    transform.GetComponent<Image>().color = Persistencia.basico;
                }else if (Persistencia.partida.mundos[i-1].completado)
                {
                    transform.GetComponent<Image>().color = Persistencia.basico;
                }
                else
                {
                    transform.GetComponent<Image>().color = Persistencia.oscuro;
                }
            }
            i++;
        }

        if (true)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void traerCohete()
    {
        if (!ayuda.enabled && transform.GetComponent<Image>().color != Persistencia.oscuro)
        {
            cSpace.moverCohete(this);
        }
    }

    public Vector3 getPosition()
    {
        return this.transform.position;
    }

    public void loadScene()
    {
        if (!escena.Equals(""))
        {
            coheteController.setEscenaDestruida(true);
            SceneMgr.loadScene(escena);
        }
    }

}
