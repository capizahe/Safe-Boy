using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracionObjetos : MonoBehaviour
{

    public Text texto;
    public GameObject player;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Extintor")
        {
            texto.text = col.tag;
        }
        else if (col.tag == "fuego")
        {
            restartPosition();
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Extintor")
        {
            texto.text = "";
        }
    }
    void restartPosition()
    {
      player.transform.position = new Vector3(4.82f, -2.57f, -3.469688f);
    }


}
