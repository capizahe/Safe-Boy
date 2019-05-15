using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


        b1.onClick.AddListener(clic);
        b2.onClick.AddListener(clic);
        b3.onClick.AddListener(clic);
        b4.onClick.AddListener(clic);

    }


    void clic() {


        string[] R = op[6].Split(')');
        

        string r1 = a1.text.Substring(5,1);
        string r2 = a2.text.Substring(5, 1);
        string r3 = a3.text.Substring(5, 1);
        string r4 = a4.text.Substring(5, 1);


        Debug.Log(r1);
        Debug.Log((R[0]));

        Debug.Log((r2[0]));
        Debug.Log((r3[0]));
        Debug.Log((r4[0]));

        Debug.Log(R[0].Equals(r1));
        Debug.Log(R[0].Equals(r2));
        Debug.Log(R[0].Equals(r3));
        Debug.Log(R[0].Equals(r4));



        if (R[0].Equals(r1))
        {
            Debug.Log(a1.text);

        }

        if (R[0].Equals(r2))
            Debug.Log(a2.text);

        if (R[0].Equals(r3))
            Debug.Log(a3.text);

        if (R[0].Equals(r4))
            Debug.Log(a4.text);
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
