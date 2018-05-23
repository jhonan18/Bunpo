using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeController : MonoBehaviour {

    public Vector3 target;
    public float speed = 5f;
    Vector3 targetInicial;
    //Vector3 aux;
    public LugarController casilla;
    LugarController LCAux;
    LugarController casillaAnterior;
    public GameObject cuadricula;

    public Sprite niña1;
    public Sprite niña2;
    public Sprite niña3;

    public Sprite niño1;
    public Sprite niño2;
    public Sprite niño3;

    public Sprite alien1;
    public Sprite alien2;

    // Use this for initialization
    void Start () {

        Time.timeScale = 1;

        //Debug.Log("position: " + cuadricula.transform.GetChild(Persistencia.casillaCuadriculaActual).position);

        if (Persistencia.puntoActual != 0 && Persistencia.casillaCuadriculaActual != 0)
        {
            transform.position = Persistencia.posicionPuntoActual;
            casillaAnterior = (LugarController)cuadricula.transform.GetChild(Persistencia.casillaCuadriculaAnterior).GetComponent<LugarController>();
            casilla = (LugarController)cuadricula.transform.GetChild(Persistencia.casillaCuadriculaActual).GetComponent<LugarController>();
            
        }
        else
        {
            casillaAnterior = casilla;
        }

        target = transform.position;
        targetInicial = transform.position;

        //Persistencia.load();
        asignar(Persistencia.partida.personaje);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && casilla.up != null && getEnPosicion(transform.position, target))
        {
            if ((LCAux = casilla.up.getUp()) != null && (LCAux == casillaAnterior || casilla.GetComponentInChildren<CompPoint>().escena.Equals("") || Persistencia.partida.mundos[Persistencia.getMundoNum()].puntos[casilla.GetComponentInChildren<CompPoint>().numero].completado))
            {
                setTarget(LCAux);
            }
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && casilla.down != null && getEnPosicion(transform.position, target))
        {
            if ((LCAux = casilla.down.getDown()) != null && (LCAux == casillaAnterior || casilla.GetComponentInChildren<CompPoint>().escena.Equals("") || Persistencia.partida.mundos[Persistencia.getMundoNum()].puntos[casilla.GetComponentInChildren<CompPoint>().numero].completado))
            {
                setTarget(LCAux);
            }
        } else if (Input.GetKeyDown(KeyCode.RightArrow) && casilla.right != null && getEnPosicion(transform.position, target))
        {
            if ((LCAux = casilla.right.getRight()) != null && (LCAux == casillaAnterior || casilla.GetComponentInChildren<CompPoint>().escena.Equals("") || Persistencia.partida.mundos[Persistencia.getMundoNum()].puntos[casilla.GetComponentInChildren<CompPoint>().numero].completado))
            {
                setTarget(LCAux);
            }
        } else if (Input.GetKeyDown(KeyCode.LeftArrow) && casilla.left != null && getEnPosicion(transform.position, target))
        {
            if ((LCAux = casilla.left.getLeft()) != null && (LCAux == casillaAnterior || casilla.GetComponentInChildren<CompPoint>().escena.Equals("") || Persistencia.partida.mundos[Persistencia.getMundoNum()].puntos[casilla.GetComponentInChildren<CompPoint>().numero].completado))
            {
                setTarget(LCAux);
            }
        } else if (Input.GetKeyDown(KeyCode.Z) && casilla != null && getEnPosicion(transform.position, target))
        {
            Persistencia.posicionPuntoActual = transform.position;
            casilla.openScene();
        }

        //Movimiento
        if (target.x != transform.position.x || target.y != transform.position.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    public float distancia(Vector3 a, Vector3 b)
    {
        return Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2f) + Mathf.Pow(a.y - b.y, 2f));
    }

    public void setTarget(LugarController nCasilla)
    {
        casilla.setCasillaAnterior();
        casillaAnterior = casilla;
        casilla = nCasilla;
        targetInicial = target;
        target = casilla.transform.position;
        target.z = targetInicial.z;
    }

    public bool getEnPosicion(Vector3 a, Vector3 b)
    {
        if (distancia(a,b) < 0.5)
        {
            return true;
        }
        return false;
    }

    public void asignar(string sprite)
    {
        if (sprite.Equals("niña 1"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niña1;
        }
        else if (sprite.Equals("niña 2"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niña2;
        }
        else if (sprite.Equals("niña 3"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niña3;
        }
        else if (sprite.Equals("niño 1"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niño1;
        }
        else if (sprite.Equals("niño 2"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niño2;
        }
        else if (sprite.Equals("niño 3"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = niño3;
        }
        else if (sprite.Equals("extraterrestre 1"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = alien1;
        }
        else if (sprite.Equals("extraterrestre 2"))
        {
            this.GetComponentInChildren<SpriteRenderer>().sprite = alien2;
        }
    }

}
