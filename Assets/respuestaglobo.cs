using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class respuestaglobo : MonoBehaviour,IPointerClickHandler{

    public batallaController bc;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text texto;
    //public sc1 script;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (bc.posLlenar == 0)
        {
            text1.text = texto.text;
        }else if (bc.posLlenar == 1)
        {
            text2.text = texto.text;
        }
        else
        {
            text3.text = texto.text;
        }


    }
}
