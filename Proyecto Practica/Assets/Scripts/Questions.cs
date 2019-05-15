
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

    public string Preguntados;

    private  ColorBlock grn;
    private  ColorBlock red;

    

    private bool [] qa;
    private string[] q;
    private string[] op;
    // Start is called before the first frame update
    void Start()
     {
        
        if (moverCamara.getCat() == 1)
            Camera.main.backgroundColor = Color.yellow;

        if (moverCamara.getCat() == 2)
            Camera.main.backgroundColor = Color.red;

        if (moverCamara.getCat() == 3)
            Camera.main.backgroundColor = Color.blue;

        
        q = new string[2];
      //inicio de preguntas
      //q[i] = "Tipo de pregunta| pregunta|a) |b) |c) |d) |letra de Respuesta correcta "
        q[0] = "1|¿Que color de extintor se debe usar para apagar las llamas en equipos electricos?|a)Rojo|b) Amarillo|c) Verde|d) blanco|d";
        q[1] = "1|¿Cual es el color de las señales preventiavas?|a) Amarillo|b)Azul|c) Rojo|d)Naranja|a";
            


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
            //Colorear botones de correcta e incorrecta
            //Timer para despues devolver
            
        }

      

        
        
        
        SceneManager.LoadScene("Preguntados");
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

        long start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        long end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        while (end - start < 2000)
            end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        SceneManager.LoadScene("Preguntados");

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

        long start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        long end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        while (end - start < 2000)
            end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        SceneManager.LoadScene("Preguntados");
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


        long start = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        long end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        while (end - start < 2000)
            end = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        SceneManager.LoadScene(Preguntados);
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
