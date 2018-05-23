using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour,IDropHandler {

    public Image imagen;
    public sc1 script1;
    public Draggable.Tipo tipo = Draggable.Tipo.SUJETO;

    void Start()
    {
        imagen = GameObject.Find("Image").GetComponent<Image>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        
        imagen = gameObject.GetComponent<Image>();

        //Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            imagen.sprite = Resources.Load<Sprite>("Sprites/astro2");
            d.transform.GetChild(0).transform.SetParent(script1.holi());
            if (tipo == d.tipo)
            {
                //CalcularPuntos.sumar();
            }
            d.parentToReturnTo = this.transform.parent.parent.parent;
        }

    }
}
