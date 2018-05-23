using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteController : MonoBehaviour {

    public float speed = 5f;
    public float padding = 1f;
    public float Rspeed = 5f;
    float tamañoI = 0.23f;

    public Canvas ayuda;

    public Vector3 target;
    Vector3 targetInicial;
    Vector3 aux;

    public FuegoController fuegoController;
    public GameObject pInicio;
    public GameObject pFinal;

    public static Vector3 posicionCoheteFinal;
    private static bool escenaDestruida = false;

    public static Planeta_GeneralController planeta;

    // Use this for initialization
    void Start ()
    {
        if (escenaDestruida)
        {
            transform.position = new Vector3(posicionCoheteFinal.x, posicionCoheteFinal.y, posicionCoheteFinal.z);
            planeta = transform.parent.GetChild(Persistencia.getMundoNum()).GetComponent<Planeta_GeneralController>();
        }

        target = transform.position;
        targetInicial = transform.position;

        if (!Persistencia.partida.ayudaEspacio)
        {
            ayuda.enabled = true;
            Persistencia.partida.ayudaEspacio = true;
            Persistencia.save();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Tamaño cohete
        float tam = (tamañoI / 2) + ((distancia(pFinal.transform.position, transform.position) / distancia(pInicio.transform.position, pFinal.transform.position)) * tamañoI / 2);
        transform.localScale = new Vector3(tam, tam, tam);

        //Debug.Log(distancia(target, transform.position));
        //Debug.Log(transform.position.x+" "+ transform.position.y + " "+ transform.position.z + " "+ target.x + " " + target.y + " " + target.z + "/ " + (speed * ((distancia(targetInicial, target) / 2) - distancia(aux, transform.position) + 0.2f)));
        if (distancia(target, transform.position) >= 0.1)
        {
            //Fuego animacion
            fuegoController.setOnFire(true);


            //Movimiento y rotacion
            transform.position = Vector3.MoveTowards(transform.position, target, (speed * ((distancia(targetInicial, target) / 2) - distancia(aux, transform.position) + 0.2f)) * Time.deltaTime);
       

            Vector2 direction = target - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        } else
        {
            fuegoController.setOnFire(false);
        }
        //Debug.DrawLine(transform.position, target, Color.green);
        //Debug.DrawLine(transform.position, aux, Color.red);
        

        //Debug.Log(distancia(target, transform.position));
        //Debug.Log(pr);
        posicionCoheteFinal = transform.position;

        if (Input.GetKeyDown(KeyCode.Z) && planeta != null && distancia(target, transform.position) <= 0.1)
        {
            Persistencia.mundoActual = planeta.escena;
            planeta.loadScene();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneMgr.loadScene("SeleccionPersonaje");
        }

    }

    public float distancia(Vector3 a, Vector3 b)
    {
        //Debug.Log(target.x + " " + target.y + " / " + transform.position.x + " " + transform.position.y);
        return (float)System.Math.Round((decimal)Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2f) + Mathf.Pow(a.y - b.y, 2f)),3);
    }

    public void setTarget(Planeta_GeneralController plan)
    {
        if (distancia(target,transform.position)<0.1)
        {
            planeta = plan;
            targetInicial = target;
            target = plan.transform.position;
            target.z = 0f;
            aux = new Vector3(((targetInicial.x - target.x) / 2) + target.x, ((targetInicial.y - target.y) / 2) + target.y, 0f);
        }

    }

    public void setEscenaDestruida(bool nED)
    {
        escenaDestruida = nED;
    }

}
