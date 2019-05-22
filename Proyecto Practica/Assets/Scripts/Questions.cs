
using UnityEngine;

using UnityEngine.UI;
using System.Threading;


using UnityEngine.SceneManagement;
using System;

public class Questions : MonoBehaviour
{
    public Text question;

    public Text a1;
    public Text a2;
    public Text a3;
    public Text a4;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button back;

    public string Preguntados;

    private  ColorBlock grn;
    private  ColorBlock red;

    

    private bool [] qa;
    private string[] q;
    private string[] op;
    // Start is called before the first frame update
    void Start()
     {
        back.enabled = false;


        if (moverCamara.getCat() == 1)
            Camera.main.backgroundColor = Color.yellow;

        if (moverCamara.getCat() == 2)
            Camera.main.backgroundColor = Color.red;

        if (moverCamara.getCat() == 3)
            Camera.main.backgroundColor = Color.blue;

        
        q = new string[6];
      //inicio de preguntas
      //q[i] = "Tipo de pregunta| pregunta|a) |b) |c) |d) |letra de Respuesta correcta "
        q[0] = "1|¿Que color de extintor se debe usar para apagar las llamas en equipos electricos?|a)Rojo|b) Amarillo|c) Verde|d) blanco|d";
        q[1] = "1|¿Cual es el color de las señales preventiavas?|a) Amarillo|b) Azul|c) Rojo|d) Naranja|a";
        q[2] = "1|Durante una emergencia, usted debe:|a) Gritar pidiendo ayuda|b Correr buscando alguna autoridad o ente de seguridad|c) No hacer nada|d) Mantener la calma|d)";
        q[3] = "1|El equipo de emergencia básico debe tener: Radio y linterna de mano de baterias, baterias adicionales, equipo primeros auxilios, agua, alimentos (enlatados , frutos secos, almendras etc..)|a) Falso|b) Solo agua y alimentos|c) Verdadero|d) Todo menos baterías extra|c";
        q[4] = "1|Antes de un terremoto ten presente: Los lugares seguras de tu residencia y de tu colegio (por ejemplo campos abiertos). Los marcos de las puertas o muebles resistentes son los lugares recomendados para protegerse en estos casos|a) Es verdad|b) ¿De que habla?|c) Tal vez|d) Flaso|a";
        q[5] = "1|En caso de evacuación asegúrate de llevar contigo:|a) Agua, alimentos no perecederos, ropa, gruesa y elementos primeros auxilios|b) A tu perro, a tu mama, una maleta con tus cosas personales y agua|c) No lleves nada, ya el desastre se te llevó todo, bueno solo agua |d) Agua, ropa, alimentos y tu compu para jugar este juego :v|a";


        qa = new bool[q.Length];

        op = pregunta(moverCamara.getCat()).Split('|');
        
        question.text =op[1] ;
        a1.text = "     " + op[2];
        a2.text = "     " + op[3];
        a3.text = "     " + op[4];
        a4.text = "     " + op[5];


        b1.onClick.AddListener(clic1);
        b2.onClick.AddListener(clic2);
        b3.onClick.AddListener(clic3);
        b4.onClick.AddListener(clic4);

    }


    void clic1() {

        string[] R = op[6].Split(')');

        string r = a1.text.Substring(5, 1);

        if (R[0].Equals(r))
        {
            b1.GetComponent<Image>().color = Color.green;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;


            Debug.Log("Correcto");
        }
        else
        {
            b1.GetComponent<Image>().color = Color.red;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Incorrecto");
            
            
        }





        back.enabled = true;
        
    }

    void clic2()
    {
        Debug.Log(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        string[] R = op[6].Split(')');

        string r = a2.text.Substring(5, 1);

        if (R[0].Equals(r))
        {
            b2.GetComponent<Image>().color = Color.green;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Correcto");
        }
        else {
            b2.GetComponent<Image>().color = Color.red;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Incorrecto");
        }


        back.enabled = true;

    }

    void clic3()
    {
        Debug.Log(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        string[] R = op[6].Split(')');

        string r = a3.text.Substring(5, 1);

        if (R[0].Equals(r))
        {
            b3.GetComponent<Image>().color = Color.green;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Correcto");
        }
        else {
            b3.GetComponent<Image>().color = Color.red;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Incorrecto");
        }


        back.enabled = true;
    }

    void clic4()
    {
       Debug.Log( DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()); 
        string[] R = op[6].Split(')');

        string r = a4.text.Substring(5, 1);

        if (R[0].Equals(r))
        {
            b4.GetComponent<Image>().color = Color.green;
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Correcto");
        }
        else {
            b4.GetComponent<Image>().color = Color.red;
            
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
            Debug.Log("Incorrecto");
        }



        back.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
          
    }



    
        
             
     private System.Random rd = new System.Random();
    
     string pregunta(int c) {


        int pos = rd.Next(0,q.Length);

        
        
        while (qa[pos] && (q[pos].Split('|').Equals(c)))
            pos = rd.Next(0, q.Length);


        string s = q[pos];
        qa[pos] = true;

        return s;
        

        
        

    } 


    
}
