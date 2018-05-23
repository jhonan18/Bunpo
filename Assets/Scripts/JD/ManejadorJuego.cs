using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorJuego : MonoBehaviour {
	public int Totalnavesgrandes = 1;
	public static string ColorSeleccionado;
	public static int Numpieces=9;
	public List<nave1> misnaves1 = new List<nave1> ();//List<nave>();
	public List<GameObject> Generadas = new List<GameObject> ();//List<nave>();
	public List<GameObject>Correctas = new List<GameObject> ();
	public List<GameObject>Incorrectas = new List<GameObject> ();
    public List<List<nave1>> navesGrandes = new List<List<nave1>>();
    public List<nave1> navetemp = new List<nave1>();

    
	public string tipoactual;
	public Text textoEncabezado;
	public Text textoCorrectas;
	public Text textoIncorrectas;
	public AudioSource misonido;
	public Text textoEnAyuda;
	public Text textoAyudaS;
	public int puntaje=0;
	public string seleccionerronea;
	public int totalIncorrectas=0;
	public int totalCorrectas=0;
    public Button miboton;
    public naveG lanave;
    public Text mit;
   // public ButtonAction miac;
    public int x = -7;
    Vector2 pos;
    public int y = 8;
    public nave1 nave;
    public string PalabraObjetivo = "Sujeto";

    public MiniJuegoController mini;

    public GameObject miobjeto;
    public GameObject padre;
    public string nivelcompletado;

    public Canvas error; 

    void Start () {
		GameObject miobjeto = new GameObject ();
		miobjeto=GameObject.Find("SpaceShip");

        //nave nave1= new nave();
        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "El perro" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "Come" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "En casa" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        //navesGrandes.AddRange (misnaves1);
        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Carolina" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Arrieta" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "Estudia" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "Debajo" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "del sofa" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Carlos y" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Lucas" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "Juegan" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "Videojuegos" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Suzan " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "es" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "muy" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "Bella" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Adrian " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "Corre" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "en " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "el coliseo" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Lizeth " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "ha" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "corrido" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "en " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "el parque" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();

        nave = new nave1() { num = 1, tipo = "Sujeto", palabra = "Catherin " };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Verbo", palabra = "escucha" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 2, tipo = "Predicado", palabra = "musica" };
        misnaves1.Add(nave);
        nave = new nave1() { num = 3, tipo = "Predicado", palabra = "en el bus" };
        misnaves1.Add(nave);
        navesGrandes.Add(new List<nave1>(misnaves1));
        misnaves1.Clear();;




        int dice;
        nave1 navex;

        int dif = 0;

        if (Persistencia.getMundoNum() != 0)
        {
            dif = Persistencia.partida.dificultad-1;
        }
        Debug.Log(BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif].Count);
        dice = Random.Range(0, BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif].Count);
        Debug.Log(dice);
        navetemp = new List<nave1>();
        string tipoAux = "";
        for (int j = 0; j < BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif][dice].partes.Count; j++)
        {
            if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif][dice].sujeto.Contains(j))
            {
                tipoAux = "Sujeto";
            }else if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif][dice].verbo.Contains(j))
            {
                tipoAux = "Verbo";
            }
            else if (BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif][dice].predicado.Contains(j))
            {
                tipoAux = "Predicado";
            }
            navetemp.Add(new nave1() {num = j+1, tipo = tipoAux, palabra = BDFrases.mundos[Persistencia.getMundoNum()].juegos[0].frases[dif][dice].partes[j]});
        }

        foreach (nave1 min in navetemp)
        {
            navex = min;

            Vector3 randompos = new Vector3(Random.Range(-2, 2), Random.Range(-2, 5), Random.Range(200, 205));
            GameObject Clon1 = Instantiate(miobjeto, randompos, Quaternion.identity) as GameObject;


            //dice=Random.Range (0, misnaves.Count);
            //navex = misnaves [dice];
            Clon1.GetComponent<CambiarColor>().Type = navex.tipo;
            Clon1.GetComponentInChildren<TextMesh>().text = navex.palabra;
            Generadas.Add(Clon1);



        }
        Destroy(miobjeto);





        /*int dice;
		nave1 navex;

        for (int i = 0; i < Totalnavesgrandes; i++)
        {
            dice = Random.Range(0, navesGrandes.Count);
            navetemp = new List<nave1>(navesGrandes[dice]);
            foreach (nave1 min in navetemp)
            {
                navex = min;

                Vector3 randompos = new Vector3(Random.Range(-2, 2), Random.Range(-2, 5), Random.Range(200, 205));
                GameObject Clon1 = Instantiate(miobjeto, randompos, Quaternion.identity) as GameObject;


                //dice=Random.Range (0, misnaves.Count);
                //navex = misnaves [dice];
                Clon1.GetComponent<CambiarColor>().Type = navex.tipo;
                Clon1.GetComponentInChildren<TextMesh>().text = navex.palabra;
                Generadas.Add(Clon1);



            }
        }
		Destroy (miobjeto);*/

	}



	void Update () {

		if (Numpieces == 0) {
			ColorSeleccionado = "HOILA0;";
		}
	}
	public void MostrarPista(){


		/*textoEnAyuda=GameObject.FindGameObjectWithTag ("AyudaCon").GetComponent<Text> ();
		textoEnAyuda.text="Recuerda:";*/



		foreach (GameObject i in Generadas) {

			if (i.GetComponent<CambiarColor> ().colorSeleccionado != i.GetComponent<CambiarColor> ().ColorVerdadero) {
				textoAyudaS=GameObject.FindGameObjectWithTag ("AyudaCon").GetComponent<Text> ();
				if (i.GetComponent<CambiarColor> ().ColorVerdadero == "Verde") {
					tipoactual="Predicado";
					textoAyudaS.text="El Predicado es la accion que hace algun contexto determinado, explica lugar, espacio tiempo o modo";
					break;
				}
				if (i.GetComponent<CambiarColor> ().ColorVerdadero == "Rojo") {
					tipoactual="Verbo";
					textoAyudaS.text="El Verbo es la accion que realiza el sujeto";
					break;
				}
				if (i.GetComponent<CambiarColor> ().ColorVerdadero == "Azul") {
					tipoactual="Sujeto";
					textoAyudaS.text="El Sujeto es de quien se habla en la frase";
					break;
				}

			}
		}
	}
	public void CerrarSonido(){
		this.misonido.enabled = false;
	}
	public 	List<GameObject> retornoList(){
		return this.Generadas;
	}
	public void ChangeText(){
		

		foreach (GameObject i in Generadas) {
			//print (i);
			if(i.GetComponent<CambiarColor>().colorSeleccionado==i.GetComponent<CambiarColor>().ColorVerdadero){
				Correctas.Add (i);
			}
			if(i.GetComponent<CambiarColor>().colorSeleccionado!=i.GetComponent<CambiarColor>().ColorVerdadero){
				Incorrectas.Add (i);//Debug.Log ("nave "+ i.GetComponentInChildren<TextMesh>().text+" Incorrecta");
			}

		}
		textoCorrectas = GameObject.FindGameObjectWithTag ("TextoCorrectas").GetComponent<Text> ();
		textoCorrectas.text = "";
		//textoCorrectas.text = "\r";
		foreach (GameObject i in Correctas) {
			textoCorrectas.text+="Nave "+i.GetComponentInChildren<TextMesh>().text+" Correct"+"\n";
			totalCorrectas++;
		}
		textoIncorrectas = GameObject.FindGameObjectWithTag ("TextoIncorrectas").GetComponent<Text> ();
		textoIncorrectas.text = "";
		//textoCorrectas.text = "\r";
		foreach (GameObject i in Incorrectas) {
			textoIncorrectas.text+="Nave "+i.GetComponentInChildren<TextMesh>().text+" Incorrect"+"\n";
			totalIncorrectas++;
		}
		textoEncabezado = GameObject.FindGameObjectWithTag ("TextoEncabezado").GetComponent<Text> ();
		textoEncabezado.text="Puntaje: "+puntaje+"   Tu Resultado Fue:";

        if (Incorrectas.Count > 0)
        {
            //error.enabled = true;
            mini.error();
        }
        else
        {
            mini.correcto();
        }


        Correctas.Clear ();
		Incorrectas.Clear ();
		totalCorrectas = 0;
		totalIncorrectas = 0;
		 
	}
	public string retornotipoactual(){
		return this.tipoactual;
	}

	}
public class naveG
{
    public List<nave1> misnaves11 = new List<nave1>();
}
public class nave1{

	public int num;
	public string tipo;
	public string palabra;
	public string ColorVerdadero;
	public string ColorSeleccionado;
	public nave1(int n, string t, string pal){
		num=n;
		tipo=t;
		palabra=pal;
	}
	public nave1(){
		num=1;
		tipo="t";
		palabra="i";
		ColorVerdadero="8";
		ColorSeleccionado="778";
	}
  

};

