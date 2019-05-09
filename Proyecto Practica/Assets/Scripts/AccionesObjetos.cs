using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccionesObjetos
{
    private Text text;
    private string tag;
    private GameObject player;
    private GameObject currentObject;


    public AccionesObjetos(string tag, GameObject player, GameObject currentObject, Text text)
    {
        this.text = text;
        this.tag = tag;
        this.player = player;
        this.currentObject = currentObject;
    }

    public void checkTag()
    {
        if (this.tag.Equals("fuego")) { restartPosition(); }
    }

    public bool isGrabbable(string tag)
    {
        if (tag != null)
            return !tag.Equals("fuego");
        return true;
    }

    public GameObject isObjective(string tag)
    {     
         return (tag!=null)?GameObject.FindGameObjectWithTag(tag):null;
    }

    private void restartPosition()
    {
        player.transform.position = new Vector3(4.82f, -2.57f, 0f);
        player.GetComponent<Rigidbody2D>().velocity= new Vector2(0f,0f);
        text.text = "Objeto = [Vacio]";
    }
 

}
