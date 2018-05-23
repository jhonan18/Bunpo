using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcular : MonoBehaviour {

    public int calcularPuntos()
    {
        int num=0;
        if (this.transform.childCount>0)
        {
            num = 1;
        }

        return num;
    }
}
