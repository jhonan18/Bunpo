using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ordenarController : MonoBehaviour {

    public Text cuadro1;
    public Text cuadro2;
    public Text cuadro3;

    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;


    public MiniJuegoController mini;

    int n = -1;
    int dif = 0;

    // Use this for initialization
    void Start () {

        dif = 0;

        if (Persistencia.getMundoNum() != 0)
        {
            dif = Persistencia.partida.dificultad-1;
        }
        n = Random.Range(0, BDFrases.mundos[Persistencia.getMundoNum()].juegos[1].frases[dif].Count);
        

        List<string> faux = new List<string>(BDFrases.mundos[Persistencia.getMundoNum()].juegos[1].frases[dif][n].partes);

        faux = DesordenarLista(faux);

        cuadro1.text = faux[0];
        cuadro2.text = faux[1];
        cuadro3.text = faux[2];

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static List<T> DesordenarLista<T>(List<T> input)
    {
        List<T> arr = input;
        List<T> arrDes = new List<T>();

        System.Random randNum = new System.Random();
        while (arr.Count > 0)
        {
            int val = randNum.Next(0, arr.Count - 1);
            arrDes.Add(arr[val]);
            arr.RemoveAt(val);
        }

        return arrDes;
    }

    public void verificar()
    {
        if (panel1.transform.childCount == 0 || panel2.transform.childCount == 0 || panel3.transform.childCount == 0)
        {
            Debug.Log("Paila");
        }
        else
        {
            string original = "";
            string prueba = "";

            if (n != -1)
            {
                foreach (string s in BDFrases.mundos[Persistencia.getMundoNum()].juegos[1].frases[dif][n].partes)
                {
                    original += s;
                }

                prueba += panel1.transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
                prueba += panel2.transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
                prueba += panel3.transform.GetChild(0).GetChild(0).GetComponent<Text>().text;
                //Debug.Log(prueba);
                //Debug.Log(original);
                if (original.Equals(prueba))
                {
                    mini.correcto();
                }
                else
                {
                    mini.error();
                }
            }
        }
    }

}
