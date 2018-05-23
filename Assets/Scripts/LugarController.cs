using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LugarController : MonoBehaviour {

    public LugarController up;
    public LugarController down;
    public LugarController right;
    public LugarController left;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public LugarController getRight()
    {
        if (transform.childCount > 0)
        {
            if(transform.GetChild(0).gameObject.GetComponent<CompPoint>() != null)
            {
                return this;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaV>() != null)
            {
                return null;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaH>() != null)
            {
                if (right != null)
                {
                    return right.getRight();
                }
                else
                {
                    return null;
                }
            }
        }
        else
        {
            return null;
        }
        return null;
    }

    public LugarController getLeft()
    {
        if (transform.childCount > 0)
        {
            if (transform.GetChild(0).gameObject.GetComponent<CompPoint>() != null)
            {
                return this;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaV>() != null)
            {
                return null;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaH>() != null)
            {
                if (left != null)
                {
                    return left.getLeft();
                }
                else
                {
                    return null;
                }
            }
        }
        else
        {
            return null;
        }
        return null;
    }

    public LugarController getUp()
    {
        if (transform.childCount > 0)
        {
            if (transform.GetChild(0).gameObject.GetComponent<CompPoint>() != null)
            {
                return this;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaV>() != null)
            {
                if (up != null)
                {
                    return up.getUp();
                }
                else
                {
                    return null;
                }
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaH>() != null)
            {
                return null;
            }
        }
        else
        {
            return null;
        }
        return null;
    }

    public LugarController getDown()
    {
        if (transform.childCount > 0)
        {
            if (transform.GetChild(0).gameObject.GetComponent<CompPoint>() != null)
            {
                return this;
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaV>() != null)
            {
                if (down != null)
                {
                    return down.getDown();
                }
                else
                {
                    return null;
                }
            }
            else if (transform.GetChild(0).gameObject.GetComponent<CompCasillaH>() != null)
            {
                return null;
            }
        }
        else
        {
            return null;
        }
        return null;
    }

    public void setCasillaAnterior()
    {
        Persistencia.casillaCuadriculaAnterior = getNumberOfChildInParent();
    }

    public void openScene()
    {
        CompPoint aux;
        if (transform.childCount > 0)
        {
            if ((aux = transform.GetChild(0).gameObject.GetComponent<CompPoint>()) != null)
            {
                if (!aux.getEscena().Equals(""))
                {
                    Persistencia.casillaCuadriculaActual = getNumberOfChildInParent();
                    Persistencia.puntoActual = aux.numero;
                    Persistencia.ejercicioActual = 1;
                    Persistencia.miniJuegoActual = aux.getEscena();
                    Persistencia.contPuntos = 0;
                    SceneManager.LoadScene(aux.getEscena());
                }
            }
        }
    }

    public int getNumberOfChildInParent()
    {
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            if (transform.parent.GetChild(i).Equals(transform))
            {
                return i;
            }
        }
        return -1;
    }
}
