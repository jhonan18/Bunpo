using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Siguiente : MonoBehaviour {

    public Button boton;
    public batallaController bc;
    private void Start()
    {
        boton.onClick.AddListener(siguiente);
    }

    public void siguiente()
    {
        if (bc.listo)
        {
            SceneManager.LoadScene("scene");
        }
    }
}