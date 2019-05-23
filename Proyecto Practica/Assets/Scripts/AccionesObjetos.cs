using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (this.tag.Equals("fuego") || this.tag.Equals("fuegoL2")) { restartPosition(this.tag); }
    }

    public bool isGrabbable(string tag)
    {
        if (tag != null)
            return !tag.Equals("fuego") || !tag.Equals("fuegoL2");
        return true;
    }

    public bool isJustUsable(string tag)
    {
        if(tag!= null)
        {
            return tag.Equals("RegistroGas");
        }
        return false;
    }

    public GameObject isObjective(string tag)
    {     
         return (tag!=null)?GameObject.FindGameObjectWithTag(tag):null;
    }

    private void restartPosition(string tag)
    {
        switch (tag)
        {
            case "fuego":
                SceneManager.LoadScene("EscenaNivel1"); Debug.Log("Entro a Escena Nivel 1");
                break;
            case "fuegoL2":
                SceneManager.LoadScene("EscenaNivel2"); Debug.Log("Entro a Escena Nivel 1");

                break;
        }    
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        text.text = "Objeto = [Vacio]";

    }
 

}
