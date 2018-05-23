using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BDFrases{

    public class Ejercicio
    {
        public List<string> frase;
        public List<int> respuesta;

        public Ejercicio(List<string> nFrase, List<int> nRes)
        {
            frase = nFrase;
            respuesta = nRes;
        }

    }

    public class Frase //new
    {
        public List<string> partes;
        public List<int> sujeto;
        public List<int> verbo;
        public List<int> predicado;

        public Frase(List<string> nPartes, List<int> nSujeto, List<int> nVerbo, List<int> nPredicado)
        {
            partes = nPartes;
            sujeto = nSujeto;
            verbo = nVerbo;
            predicado = nPredicado;
        }
    }

    public class Juego //new
    {
        public List<List<Frase>> frases;

        public Juego()
        {
            frases = new List<List<Frase>>();
            frases.Add(new List<Frase>());
            frases.Add(new List<Frase>());
            frases.Add(new List<Frase>());
        }
    }

    public class Mundo //new
    {
        public List<Juego> juegos;
        
        public Mundo()
        {
            juegos = new List<Juego>();
            juegos.Add(new Juego());
            juegos.Add(new Juego());
            juegos.Add(new Juego());
            juegos.Add(new Juego());
        }
    }

    public class FraseJuego
    {
        public List<List<Ejercicio>> frases;
        public string juego;

        public FraseJuego(string nJuego)
        {
            frases = new List<List<Ejercicio>>();
            frases.Add(new List<Ejercicio>());
            frases.Add(new List<Ejercicio>());
            frases.Add(new List<Ejercicio>());

            juego = nJuego;
        }

    }


    public static List<FraseJuego> grupoFrases;
    public static List<Mundo> mundos; //new

    static void llenarFrasesNuevas()
    {
       // Debug.Log("Nuevas frases cargadas");

        mundos = new List<Mundo>();

        mundos.Add(new Mundo());
        mundos.Add(new Mundo());
        mundos.Add(new Mundo());
        mundos.Add(new Mundo());
        mundos.Add(new Mundo());

        List<string> paux = new List<string>();
        List<int> saux = new List<int>();
        List<int> vaux = new List<int>();
        List<int> praux = new List<int>();
        Frase faux;

        //mundo oracion 0
        //juego naves 0
        //dificuldad 1

        paux = new List<string>();
        paux.Add("El");
        paux.Add("universo");
        paux.Add("tiene");
        paux.Add("muchas");
        paux.Add("estrellas");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[0].frases[0].Add(faux);


        paux = new List<string>();
        paux.Add("Una");
        paux.Add("galaxia");
        paux.Add("posee");
        paux.Add("muchos");
        paux.Add("planetas");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[0].frases[0].Add(faux);


        paux = new List<string>();
        paux.Add("Nosotros");
        paux.Add("vivimos");
        paux.Add("en");
        paux.Add("el");
        paux.Add("planeta");
        paux.Add("tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[0].frases[0].Add(faux);

        //juego ordenar 1
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("viajan");
        paux.Add("por el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El hombre");
        paux.Add("ha viajado");
        paux.Add("a la luna");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("José");
        paux.Add("quiere");
        paux.Add("ser un astronauta");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[1].frases[0].Add(faux);


        //juego batalla 2
        //dificuldad 1

        paux = new List<string>();
        paux.Add("El hombre");
        paux.Add("sueña");
        paux.Add("con visitar nuevos planetas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Las cosas");
        paux.Add("flotan");
        paux.Add("en el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Mi amigo");
        paux.Add("estudia");
        paux.Add("astronomía");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("La astronomía");
        paux.Add("es");
        paux.Add("el estudio del universo");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("La luna");
        paux.Add("se encuentra");
        paux.Add("lejos de la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("van");
        paux.Add("más allá del cielo");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[2].frases[0].Add(faux);


        //juego frases 3
        //dificuldad 1
        
        paux = new List<string>();
        paux.Add("Mercurio");
        paux.Add("es");
        paux.Add("el");
        paux.Add("planeta");
        paux.Add("más");
        paux.Add("cercano");
        paux.Add("al");
        paux.Add("sol");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);
        praux.Add(7);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El");
        paux.Add("universo");
        paux.Add("se");
        paux.Add("conforma");
        paux.Add("de");
        paux.Add("muchas");
        paux.Add("galaxias");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Mi");
        paux.Add("papá");
        paux.Add("es");
        paux.Add("un");
        paux.Add("astronauta");
        paux.Add("famoso");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[0].juegos[3].frases[0].Add(faux);


        //mundo sujeto 1
        //juego ordenar 1
        //dificuldad 1

        paux = new List<string>();
        paux.Add("El mono");
        paux.Add("fue");
        paux.Add("el primer animal en ir al espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Maria");
        paux.Add("sueña");
        paux.Add("con ir al espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los satélites");
        paux.Add("orbitan");
        paux.Add("cerca de la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El primer perro");
        paux.Add("en orbitar");
        paux.Add("la tierra se llamaba Laika");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Mi abuelo");
        paux.Add("conocio");
        paux.Add("un astronauta");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los asteroides");
        paux.Add("son");
        paux.Add("como rocas gigantes en el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Dos gatitos");
        paux.Add("viven");
        paux.Add("en el observatorio espacial");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[0].Add(faux);


        //juego batalla 2
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Antonio");
        paux.Add("es");
        paux.Add("un reconocido investigador espacial");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);


        paux = new List<string>();
        paux.Add("Los cohetes");
        paux.Add("vuelan");
        paux.Add("a través del espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Las ballenas");
        paux.Add("se pueden");
        paux.Add("ver desde el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Niel Armstrong");
        paux.Add("fue");
        paux.Add("el primero en pisar la luna");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Las galaxias");
        paux.Add("son");
        paux.Add("extremadamente iguales");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los dinosaurios");
        paux.Add("se extinguieron");
        paux.Add("por un asteroide");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Yo");
        paux.Add("quiero");
        paux.Add("conocer un planetario");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Las estrellas fugaces");
        paux.Add("son");
        paux.Add("realmente meteoros");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[0].Add(faux);

        //juego ordenar 1
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Los perritos");
        paux.Add("no tienen");
        paux.Add("energías para la siguiente misión");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("No estudiaron");
        paux.Add("para el examen,");
        paux.Add("por lo que no lograron ser astrónomos");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Los cometas");
        paux.Add("pasaron");
        paux.Add("cerca de la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Los monos");
        paux.Add("se entrenaron");
        paux.Add("para ir al espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Mi papá");
        paux.Add("fue");
        paux.Add("hasta la nasa y trajo recuerdos de los astronautas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Los planetas");
        paux.Add("son");
        paux.Add("diferentes a las estrellas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[1].Add(faux);

        //juego batalla 2
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Mi gato");
        paux.Add("quiere ir");
        paux.Add("al espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);


        paux = new List<string>();
        paux.Add("Pablo");
        paux.Add("protege");
        paux.Add("el planeta de ataques extraterrestres");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Las galaxias");
        paux.Add("pueden");
        paux.Add("tener varios sistemas solares");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Los animales");
        paux.Add("son");
        paux.Add("diferentes a los humanos");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Mónica y Jhon");
        paux.Add("sueñan");
        paux.Add("con vivir en marte");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Los sonidos en el espacio");
        paux.Add("son");
        paux.Add("investigados por la nasa");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[1].Add(faux);

        //juego ordenar 1
        //dificuldad 3

        paux = new List<string>();
        paux.Add("El mono");
        paux.Add("ha sido");
        paux.Add("el animal más parecido al hombre");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("El mono");
        paux.Add("ha sido");
        paux.Add("el animal más parecido al hombre");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Estudios");
        paux.Add("revelan");
        paux.Add("que existen planetas parecidos a la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("La vida");
        paux.Add("puede existir");
        paux.Add("en otros planetas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Winston");
        paux.Add("es");
        paux.Add("un mono con super inteligencia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[1].frases[2].Add(faux);

        //juego batalla 2
        //dificuldad 3

        paux = new List<string>();
        paux.Add("El hombre");
        paux.Add("soñaba");
        paux.Add("con ir al espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Cuando una estrella");
        paux.Add("muere");
        paux.Add("se puede convertir en una agujero negro");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Sprint");
        paux.Add("es");
        paux.Add("un perro espacial que protege la galaxia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("El origen");
        paux.Add("de los cohetes");
        paux.Add("se remonta a la antigua China");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Durante la guerra fria");
        paux.Add("los cohetes");
        paux.Add("fueron inventados");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[1].juegos[2].frases[2].Add(faux);


        //mundo verbo 1
        //juego naves 1
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Mi");
        paux.Add("tio");
        paux.Add("pinta");
        paux.Add("un");
        paux.Add("cohete");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los");
        paux.Add("astronomos");
        paux.Add("leen");
        paux.Add("libros");
        paux.Add("sobre");
        paux.Add("el");
        paux.Add("espacio");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Yo");
        paux.Add("investigue");
        paux.Add("peliculas");
        paux.Add("sobre");
        paux.Add("el");
        paux.Add("espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Mi");
        paux.Add("tio");
        paux.Add("pinta");
        paux.Add("un");
        paux.Add("cohete");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El");
        paux.Add("astronomo");
        paux.Add("sonrió");
        paux.Add("antes");
        paux.Add("de");
        paux.Add("irse");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[0].Add(faux);

        //juego batalla 1
        //dificuldad 1

        paux = new List<string>();
        paux.Add("La nasa");
        paux.Add("hablo");
        paux.Add("sobre llegar a marte");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Tengo que");
        paux.Add("esforzarme");
        paux.Add("para llegar a la nasa");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El astronauta");
        paux.Add("se enferma");
        paux.Add("frecuentemente");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("La astronomia");
        paux.Add("se enfrente");
        paux.Add("a nuevos problemas cada dia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[0].Add(faux);

        //juego naves 1
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Carlos");
        paux.Add("quiere");
        paux.Add("estudiar");
        paux.Add("astronomia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Miguel");
        paux.Add("lloro");
        paux.Add("cuando");
        paux.Add("su");
        paux.Add("padre");
        paux.Add("partio");
        paux.Add("hacia");
        paux.Add("el");
        paux.Add("espacio");



        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);
        praux.Add(7);
        praux.Add(8);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Yo");
        paux.Add("tengo");
        paux.Add("que");
        paux.Add("dormirme");
        paux.Add("temprano");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Carlos");
        paux.Add("quiere");
        paux.Add("estudiar");
        paux.Add("astronomia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Daniel");
        paux.Add("juega");
        paux.Add("con");
        paux.Add("cohetes");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Jose");
        paux.Add("arregla");
        paux.Add("la");
        paux.Add("nave");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[1].Add(faux);

        //juego batalla 1
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("se cansan");
        paux.Add("en el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("En algunos planetas");
        paux.Add("nunca");
        paux.Add("llueve o nieva");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Vamos a planear");
        paux.Add("la mision");
        paux.Add("para no tener problemas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Mis primos");
        paux.Add("hacen");
        paux.Add("su tarea");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("La luna");
        paux.Add("cuasa");
        paux.Add("las mareas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[1].Add(faux);

        //juego naves 1
        //dificuldad 3

        paux = new List<string>();
        paux.Add("En");
        paux.Add("el");
        paux.Add("espacio");
        paux.Add("se");
        paux.Add("siente");
        paux.Add("mucho");
        paux.Add("vacio");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(3);
        vaux.Add(4);

        praux = new List<int>();
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Él");
        paux.Add("no");
        paux.Add("estaba");
        paux.Add("preparado");
        paux.Add("cuando");
        paux.Add("el cohete");
        paux.Add("despego");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(2);
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Yo");
        paux.Add("no");
        paux.Add("pude");
        paux.Add("ver");
        paux.Add("el cohete");
        paux.Add("porque");
        paux.Add("estaba");
        paux.Add("lloviendo");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(2);
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);
        praux.Add(7);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Los");
        paux.Add("astronautas");
        paux.Add("se");
        paux.Add("cansaron");
        paux.Add("mucho");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("El");
        paux.Add("astronomo");
        paux.Add("le");
        paux.Add("hablaba");
        paux.Add("a");
        paux.Add("los");
        paux.Add("invitados");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Melisa");
        paux.Add("apago");
        paux.Add("su");
        paux.Add("televisor");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[0].frases[2].Add(faux);

        //juego batalla 1
        //dificuldad 3

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("pueden estar mucho tiempo");
        paux.Add("en el espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("Las mareas");
        paux.Add("ocurren");
        paux.Add("en luna nueva");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("En la luna");
        paux.Add("no amanece");
        paux.Add("ni anochece");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[2].juegos[2].frases[2].Add(faux);


        //mundo predicado 2
        //juego ordenar 1
        //dificuldad 1

        paux = new List<string>();
        paux.Add("La convencion de astronomia");
        paux.Add("fue");
        paux.Add("interesante");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Camila");
        paux.Add("es");
        paux.Add("astronauta en Rusia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Esta misión espacial");
        paux.Add("será");
        paux.Add("un gran avance para la humanidad");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Juan");
        paux.Add("compro");
        paux.Add("un cohete para armar");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("comen");
        paux.Add("saludablemente");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[0].Add(faux);

        //juego batalla 2
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Yo");
        paux.Add("busque");
        paux.Add("en muchas enciclopedias");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Santiago el astronomo");
        paux.Add("se curo");
        paux.Add("antes de la mision");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("El astronauta");
        paux.Add("se puso");
        paux.Add("su traje");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Mi primo");
        paux.Add("se puso triste");
        paux.Add("porque no pudo ver el astronauta");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Norma y David");
        paux.Add("fueron");
        paux.Add("a la luna");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[0].Add(faux);

        //juego ordenar 1
        //dificuldad 2

        paux = new List<string>();
        paux.Add("La mision fue dificil");
        paux.Add("pero la siguiente");
        paux.Add("será aun peor");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Fransisco es astrónomo");
        paux.Add("y tambien");
        paux.Add("es astrnauta");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Jose será");
        paux.Add("un buen astronauta");
        paux.Add("como su padre");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("La luna sale en la noche");
        paux.Add("mientras que");
        paux.Add("el sol sale de dia");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("La luna");
        paux.Add("gira");
        paux.Add("alrededor de la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Cristian");
        paux.Add("se alisto");
        paux.Add("para ver el eclipse");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[1].Add(faux);

        //juego batalla 2
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Ellos");
        paux.Add("querian ver");
        paux.Add("la lluvia de estrellas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Jose y Raul");
        paux.Add("jugaban");
        paux.Add("a ser astronautas");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("Juliana");
        paux.Add("no podrá asistir a la mision");
        paux.Add("porque está enferma");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[1].Add(faux);

        paux = new List<string>();
        paux.Add("LLueve mucho");
        paux.Add("pero la mision");
        paux.Add("no se cancelará");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[1].Add(faux);

        //juego ordenar 1
        //dificuldad 3

        paux = new List<string>();
        paux.Add("Yo soy un astronauta");
        paux.Add("y mi vida");
        paux.Add("no fue aburrida");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("se concentran mucho");
        paux.Add("en sus misiones");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Cuando un astronauta");
        paux.Add("falla una mision");
        paux.Add("se siente muy mal");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Carlos se convirtio");
        paux.Add("en astronomo profecional");
        paux.Add("despues de estudiar mucho");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Hace mucho tiempo");
        paux.Add("los dinosaurios murieron");
        paux.Add("gracias a un meteorito");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[1].frases[2].Add(faux);

        //juego batalla 2
        //dificuldad 3

        paux = new List<string>();
        paux.Add("En el espacio");
        paux.Add("pueden existir");
        paux.Add("enfermedades raras");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Dos viejos amigos");
        paux.Add("se encontraron y");
        paux.Add("hablaron sobre sus misiones");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("En el espacio");
        paux.Add("pueden haber");
        paux.Add("accidentes inesperados");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[2].Add(faux);

        paux = new List<string>();
        paux.Add("Los satelites");
        paux.Add("artificiales");
        paux.Add("orbitan la tierra");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[3].juegos[2].frases[2].Add(faux);

        //mundo completo 4
        //juego frases 3
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Las");
        paux.Add("nuves");
        paux.Add("cosmicas");
        paux.Add("tienen");
        paux.Add("mucha");
        paux.Add("radiacion");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Los");
        paux.Add("eones");
        paux.Add("han");
        paux.Add("cambiado");
        paux.Add("desde");
        paux.Add("planetas");
        paux.Add("hasta");
        paux.Add("seres");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);
        praux.Add(7);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("En");
        paux.Add("la");
        paux.Add("pista");
        paux.Add("está");
        paux.Add("lloviendo");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("La");
        paux.Add("ciencia");
        paux.Add("no");
        paux.Add("ha");
        paux.Add("encontrado");
        paux.Add("vida");
        paux.Add("extraterrestre");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(4);

        praux = new List<int>();
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Un");
        paux.Add("agujero");
        paux.Add("negro");
        paux.Add("aun");
        paux.Add("es");
        paux.Add("un");
        paux.Add("misterio");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(4);

        praux = new List<int>();
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Adrian");
        paux.Add("suspira");
        paux.Add("al");
        paux.Add("pensar");
        paux.Add("en");
        paux.Add("el");
        paux.Add("espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[0].Add(faux);

        //juego batalla 2
        //dificuldad 1

        paux = new List<string>();
        paux.Add("Los dibujos de");
        paux.Add("la corteza lunar");
        paux.Add("son muy bonitos");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Al mirar las estrellas");
        paux.Add("él pensaba");
        paux.Add("en otros mundos");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("En New York");
        paux.Add("por un momento");
        paux.Add("se vio un ovni");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[0].Add(faux);

        paux = new List<string>();
        paux.Add("Alf era un");
        paux.Add("extraterrestre");
        paux.Add("muy amable");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[0].Add(faux);

        //juego frases 3
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Mariana");
        paux.Add("siempre");
        paux.Add("soño");
        paux.Add("con");
        paux.Add("una");
        paux.Add("vida");
        paux.Add("en");
        paux.Add("el");
        paux.Add("espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);
        praux.Add(7);
        praux.Add(8);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[1].Add(faux);
        paux = new List<string>();
        paux.Add("Alonso");
        paux.Add("espera");
        paux.Add("poder");
        paux.Add("vivir");
        paux.Add("en");
        paux.Add("otro");
        paux.Add("planeta");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[1].Add(faux);
        paux = new List<string>();
        paux.Add("Katherin");
        paux.Add("llego");
        paux.Add("al");
        paux.Add("mundo");
        paux.Add("extraterrestre");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[1].Add(faux);
        paux = new List<string>();
        paux.Add("La");
        paux.Add("mision");
        paux.Add("espacial");
        paux.Add("ha");
        paux.Add("sido");
        paux.Add("un");
        paux.Add("fracaso");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(4);

        praux = new List<int>();
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[1].Add(faux);
        paux = new List<string>();
        paux.Add("Todo");
        paux.Add("está");
        paux.Add("compuesto");
        paux.Add("por");
        paux.Add("polvo");
        paux.Add("estelar");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[1].Add(faux);

        //juego batalla 2
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Leonardo");
        paux.Add("ayudo a los astronautas");
        paux.Add("a aterrizar en la luna");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[1].Add(faux);


        paux = new List<string>();
        paux.Add("Angela recolecto fondos");
        paux.Add("para el viaje");
        paux.Add("a marte");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[1].Add(faux);


        paux = new List<string>();
        paux.Add("Los astronautas");
        paux.Add("vuelven con");
        paux.Add("muestras espaciales");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[1].Add(faux);


        paux = new List<string>();
        paux.Add("Mayita es la perrita");
        paux.Add("más capacitada para");
        paux.Add("completar la mision");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[1].Add(faux);

        //juego frases 3
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Mariana");
        paux.Add("soñaba");
        paux.Add("con");
        paux.Add("estar");
        paux.Add("en");
        paux.Add("el");
        paux.Add("espacio");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("La");
        paux.Add("nasa");
        paux.Add("inicio");
        paux.Add("un");
        paux.Add("proyecto");
        paux.Add("en");
        paux.Add("jupiter");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);

        vaux = new List<int>();
        vaux.Add(2);

        praux = new List<int>();
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("La");
        paux.Add("nave");
        paux.Add("espacial");
        paux.Add("recibio");
        paux.Add("energia");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("Lovise");
        paux.Add("observo");
        paux.Add("maravillada");
        paux.Add("desde");
        paux.Add("la");
        paux.Add("plataforma");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);
        praux.Add(3);
        praux.Add(4);
        praux.Add(5);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("El");
        paux.Add("agujero");
        paux.Add("negro");
        paux.Add("absorbio");
        paux.Add("la");
        paux.Add("nave");
        paux.Add("espacial");


        saux = new List<int>();
        saux.Add(0);
        saux.Add(1);
        saux.Add(2);

        vaux = new List<int>();
        vaux.Add(3);

        praux = new List<int>();
        praux.Add(4);
        praux.Add(5);
        praux.Add(6);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[3].frases[2].Add(faux);


        //juego batalla 2
        //dificuldad 2

        paux = new List<string>();
        paux.Add("Alejandra era");
        paux.Add("una linda alien");
        paux.Add("de ojos azules");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("Alonso el extraterrestre");
        paux.Add("tenia 5");
        paux.Add("brazos fuertes");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[2].Add(faux);


        paux = new List<string>();
        paux.Add("Mike estubo luchando");
        paux.Add("por sobrevivir en");
        paux.Add("la nave dañada");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[2].Add(faux);
        paux = new List<string>();
        paux.Add("Andrea enloquecio");
        paux.Add("por tocar");
        paux.Add("el extraño polvo espacial");


        saux = new List<int>();
        saux.Add(0);

        vaux = new List<int>();
        vaux.Add(1);

        praux = new List<int>();
        praux.Add(2);

        faux = new Frase(paux, saux, vaux, praux);

        mundos[4].juegos[2].frases[2].Add(faux);

    }


    // Use this for initialization
    public static void start()
    {
        llenarFrasesNuevas();

        grupoFrases = new List<FraseJuego>();
        grupoFrases.Add(new FraseJuego("a"));
        grupoFrases.Add(new FraseJuego("b"));
        grupoFrases.Add(new FraseJuego("c"));
        grupoFrases.Add(new FraseJuego("d"));

        //frases quemadas

        //grupo A

        List<string> auxf;
        List<int> auxi;

        auxf = new List<string>();
        auxf.Add("A");
        auxf.Add("mi");
        auxf.Add("hermano");
        auxf.Add("le");
        auxf.Add("gusta");
        auxf.Add("la");
        auxf.Add("Historia");

        auxi = new List<int>();

        auxi.Add(5);
        auxi.Add(6);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));

        auxf = new List<string>();
        auxf.Add("A");
        auxf.Add("Chema,");
        auxf.Add("le");
        auxf.Add("afectan");
        auxf.Add("mucho");
        auxf.Add("las");
        auxf.Add("críticas");
        auxf.Add("a");
        auxf.Add("su");
        auxf.Add("labor");

        auxi = new List<int>();

        auxi.Add(5);
        auxi.Add(6);
        auxi.Add(7);
        auxi.Add(8);
        auxi.Add(9);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));
        auxf = new List<string>();
        auxf.Add("Este");
        auxf.Add("cenicero");
        auxf.Add("es");
        auxf.Add("de");
        auxf.Add("Murano");
        auxf.Add("sin");
        auxf.Add("duda");
        auxf.Add("alguna");

        auxi = new List<int>();

        auxi.Add(0);
        auxi.Add(1);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));

        auxf = new List<string>();
        auxf.Add("A");
        auxf.Add("las");
        auxf.Add("ocho");
        auxf.Add("en");
        auxf.Add("punto");
        auxf.Add("se");
        auxf.Add("presentó");
        auxf.Add("a");
        auxf.Add("la");
        auxf.Add("policía");
        auxf.Add("el");
        auxf.Add("presunto");
        auxf.Add("culpable");

        auxi = new List<int>();

        auxi.Add(10);
        auxi.Add(11);
        auxi.Add(12);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));
        auxf = new List<string>();
        auxf.Add("El");
        auxf.Add("del");
        auxf.Add("bigote");
        auxf.Add("ya");
        auxf.Add("no");
        auxf.Add("pinta");
        auxf.Add("nada");

        auxi = new List<int>();

        auxi.Add(0);
        auxi.Add(1);
        auxi.Add(2);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));
        /*auxf = new List<string>();
        auxf.Add("Durante");
        auxf.Add("la");
        auxf.Add("soporífera");
        auxf.Add("conferencia,");
        auxf.Add("el");
        auxf.Add("sueño");
        auxf.Add("venció");
        auxf.Add("a");
        auxf.Add("una");
        auxf.Add("parte");
        auxf.Add("del");
        auxf.Add("público");

        auxi = new List<int>();

        auxi.Add(4);
        auxi.Add(5);

        frases.Add(new Ejercicio(auxf, auxi));*/
        /*auxf = new List<string>();
        auxf.Add("El");
        auxf.Add("ganador");
        auxf.Add("del");
        auxf.Add("premio");
        auxf.Add("literario");
        auxf.Add("admira");
        auxf.Add("sinceramente");
        auxf.Add("la");
        auxf.Add("obra");
        auxf.Add("del");
        auxf.Add("finalista");

        auxi = new List<int>();

        auxi.Add(0);
        auxi.Add(1);
        auxi.Add(2);
        auxi.Add(3);
        auxi.Add(4);

        frases.Add(new Ejercicio(auxf, auxi));*/

        auxf = new List<string>();
        auxf.Add("La");
        auxf.Add("tristeza");
        auxf.Add("nos");
        auxf.Add("embarga");
        auxf.Add("totalmente");

        auxi = new List<int>();

        auxi.Add(0);
        auxi.Add(1);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));
        auxf = new List<string>();
        auxf.Add("Mi");
        auxf.Add("amigo");
        auxf.Add("marroquí");
        auxf.Add("llegará");
        auxf.Add("a");
        auxf.Add("Barcelona");
        auxf.Add("en");
        auxf.Add("avión");

        auxi = new List<int>();

        auxi.Add(0);
        auxi.Add(1);
        auxi.Add(2);

        grupoFrases[0].frases[0].Add(new Ejercicio(auxf, auxi));
    }

    public static int getIndexG(string g)
    {
        int i = 0;
        foreach (FraseJuego fj in grupoFrases)
        {
            if (fj.juego.Equals(g))
            {
                return i;
            }
            i++;
        }
        return -1;
    }


}
