
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

        
        q = new string[10];
      //inicio de preguntas
      //q[i] = "Tipo de pregunta| pregunta|a) |b) |c) |d) |letra de Respuesta correcta "
        q[0] = "1|¿Que color de extintor se debe usar para apagar las llamas en equipos electricos?|a)Rojo|b) Amarillo|c) Verde|d) blanco|d";
        q[1] = "1|¿Cual es el color de las señales preventiavas?|a) Amarillo|b) Azul|c) Rojo|d) Naranja|a";
        q[2] = "2|Durante una emergencia, usted debe:|a) Gritar ¡Ayuda!|b) Correr y gritar|c) No hacer nada|d) Mantener la calma|d)";
        q[3] = "3|El equipo de emergencia debe tener: Radio y linterna, baterias adicionales, primeros auxilios, agua, alimentos|a) Falso|b) Solo agua |c) Verdadero|d) Todo menos baterías|c";
        q[4] = "2|Antes de un terremoto ten presente: Los lugares seguras de tu residencia y de tu colegio (Campos abiertos)|a) Es verdad|b) ¿De que habla?|c) Tal vez|d) Flaso|a";
        q[5] = "3|En caso de evacuación asegúrate de llevar contigo:|a)Equipo/Emergnecia|b) A tu perro|c) No lleves nada |d) Este juego :v|a";
        q[6] = "3|Los alimentos en el equipo de emergencia son: |a)Empanadas|b)Agua|c)b y d|d)Enlatados|c";
        q[7] = "2|Si estas en la calle y sucede un terremoto ¿Debe alejarse de?|a)Personas|b)Postes/cables|Calzada|d)Vehículos|b";
        q[8] = "2|La forma correcta de salir de un edificio en llamas es:|a)Ventanas|b)Corriendo|c)Rutas de salida|d)Gritar|c";
        q[9] = "2|Agua, alimentos no perecederos, ropa, gruesa y elementos primeros auxilios. Esto es esencian tenerlo en:|a) El carro|b) El trabajo|c)Terremotos d)Evacuaciónes|d";

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
