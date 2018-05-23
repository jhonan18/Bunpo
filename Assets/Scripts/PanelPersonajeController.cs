using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPersonajeController : MonoBehaviour {

    public Sprite niña1;
    public Sprite niña2;
    public Sprite niña3;

    public Sprite niño1;
    public Sprite niño2;
    public Sprite niño3;

    public Sprite alien1;
    public Sprite alien2;

    string categoria;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void right()
    {
        if (categoria.Equals("niña"))
        {
            if (this.GetComponent<Image>().sprite == niña1)
            {
                this.GetComponent<Image>().sprite = niña2;
            } else if (this.GetComponent<Image>().sprite == niña2)
            {
                this.GetComponent<Image>().sprite = niña3;
            } else if (this.GetComponent<Image>().sprite == niña3)
            {
                this.GetComponent<Image>().sprite = niña1;
            }
        }
        else if (categoria.Equals("niño"))
        {
            if (this.GetComponent<Image>().sprite == niño1)
            {
                this.GetComponent<Image>().sprite = niño2;
            }
            else if (this.GetComponent<Image>().sprite == niño2)
            {
                this.GetComponent<Image>().sprite = niño3;
            }
            else if (this.GetComponent<Image>().sprite == niño3)
            {
                this.GetComponent<Image>().sprite = niño1;
            }
        }
        else if (categoria.Equals("extraterrestre"))
        {
            if (this.GetComponent<Image>().sprite == alien1)
            {
                this.GetComponent<Image>().sprite = alien2;
            }
            else if (this.GetComponent<Image>().sprite == alien2)
            {
                this.GetComponent<Image>().sprite = alien1;
            }
        }


    }

    public void left()
    {
        if (categoria.Equals("niña"))
        {
            if (this.GetComponent<Image>().sprite == niña1)
            {
                this.GetComponent<Image>().sprite = niña3;
            }
            else if (this.GetComponent<Image>().sprite == niña2)
            {
                this.GetComponent<Image>().sprite = niña1;
            }
            else if (this.GetComponent<Image>().sprite == niña3)
            {
                this.GetComponent<Image>().sprite = niña2;
            }
        }
        else if (categoria.Equals("niño"))
        {
            if (this.GetComponent<Image>().sprite == niño1)
            {
                this.GetComponent<Image>().sprite = niño3;
            }
            else if (this.GetComponent<Image>().sprite == niño2)
            {
                this.GetComponent<Image>().sprite = niño1;
            }
            else if (this.GetComponent<Image>().sprite == niño3)
            {
                this.GetComponent<Image>().sprite = niño2;
            }
        }
        else if (categoria.Equals("extraterrestre"))
        {
            if (this.GetComponent<Image>().sprite == alien1)
            {
                this.GetComponent<Image>().sprite = alien2;
            }
            else if (this.GetComponent<Image>().sprite == alien2)
            {
                this.GetComponent<Image>().sprite = alien1;
            }
        }

    }

    public void asignar(string sprite)
    {
        if (sprite.Equals("niña 1"))
        {
            this.GetComponent<Image>().sprite = niña1;
        } else if (sprite.Equals("niña 2"))
        {
            this.GetComponent<Image>().sprite = niña2;
        }
        else if(sprite.Equals("niña 3"))
        {
            this.GetComponent<Image>().sprite = niña3;
        } else if (sprite.Equals("niño 1"))
        {
            this.GetComponent<Image>().sprite = niño1;
        }
        else if (sprite.Equals("niño 2"))
        {
            this.GetComponent<Image>().sprite = niño2;
        }
        else if (sprite.Equals("niño 3"))
        {
            this.GetComponent<Image>().sprite = niño3;
        }
        else if (sprite.Equals("extraterrestre 1"))
        {
            this.GetComponent<Image>().sprite = alien1;
        }
        else if (sprite.Equals("extraterrestre 2"))
        {
            this.GetComponent<Image>().sprite = alien2;
        }
    }

    public void setCategoria(string nC)
    {
        categoria = nC;
    }

}
