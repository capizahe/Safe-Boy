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

    public AccionesObjetos(string tag, GameObject player, GameObject currentObject,Text text) 
    {
        this.text = text;
        this.tag = tag;
        this.player = player;
        this.currentObject = currentObject;
    }

    public void checkTag()
    {

        if (this.tag.Equals("fuego")){restartPosition();}

    }

    public bool isGrabbable(string tag)
    {
        if (tag.Equals("fuego")) return false;
        return true;
    }

    private void restartPosition()
    {
        player.transform.position = new Vector3(4.82f, -2.57f, -3.469688f);
        text.text = "Objeto = [Vacio]";
    }

    


}
