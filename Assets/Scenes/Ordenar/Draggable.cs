using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parentToReturnTo = null;

    public enum Tipo { SUJETO, VERBO, PREDICADO };
    public Tipo tipo;
    public void OnBeginDrag(PointerEventData evenData)
    {
        //Debug.Log("OnBeginDrag");
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData evenData)
    {
        //Debug.Log("OnDrag");
        this.transform.position = evenData.position;
    }
    public void OnEndDrag(PointerEventData evenData)
    {
        //Debug.Log("OnEndDrag");
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
