using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{

    private bool [] qa;
    private string[] q;
    // Start is called before the first frame update
    void Start()
    {
        q = new string[1];
        //inicio de preguntas
        q[0] = "¿Que color de extintor se debe usar para apagar las llamas en equipos electricos?|a) Rojo| b) Amarillo, c) Verde, d) blanco|d";
        q[1] = "¿Cual es el color de las señales preventiavas?| a) Amarillo| b)Azul| c) Rojo| d)Naranja|a";


        qa = new bool[q.Length];
    }

    // Update is called once per frame
    void Update()
    {
          
    }


        
             
     private System.Random rd = new System.Random();
    
     string pregunta() {


        int pos = rd.Next(0,q.Length);
        
        while(qa[pos])
            pos = rd.Next(0, q.Length);


        string s = q[pos];
        qa[pos] = true;

        return s;
        

        
        

    } 

}
