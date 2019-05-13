using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



/*
 * 
 * Esta clase se encarga de verificar si un objeto hace contacto y se puede acceder 
 * a ellos mediante tags
 * 
 */

public class InteracionObjetos : MonoBehaviour
{

    public Text texto;
    public GameObject player;
    public GameObject currentObject = null;
    private bool hasObject = false;
    private GameObject grabbedObject=null;
    private AccionesObjetos accionesObjetos= null;

    void Start()
    {
        texto.text = "Objeto = [Vacio]";
    }

     void Update()
    {

        if(Input.GetKey(KeyCode.Space) && this.currentObject && !this.hasObject && !this.grabbedObject)
        {
            if (accionesObjetos.isGrabbable(this.currentObject.tag))
            {
                grabObject();
            }
            else
            {
                Debug.Log("The object -> " + this.currentObject.tag + " is not grabbable.");
            }
        }
        if (Input.GetKey(KeyCode.Z) && this.hasObject && this.grabbedObject)
        {
            dropObject();
        }
        if (Input.GetKey(KeyCode.X) && this.hasObject && this.grabbedObject  && RayCast("fuego") )
        {

            useObject("fuego");
            if (EscogerNivelPlayer1.currentPosition != null)
            {
                SceneManager.LoadScene("MapaPrincipalAventura");
                                EscogerNivelPlayer1.ActualPosition(EscogerNivelPlayer1.escogerNivel.posLevel2);


            }

        }
    }

    void  grabObject()
    {
        this.hasObject = true;
        this.currentObject.SetActive(false);
        this.grabbedObject = this.currentObject;
        Debug.Log("The grabbed object is -> " + this.currentObject.tag);
    }

    void dropObject()
    {
        Debug.Log(this.grabbedObject.tag);
        this.currentObject = this.grabbedObject;
        this.currentObject.SetActive(true);
        this.grabbedObject = null;
        this.hasObject = false;
        texto.text = "Objeto = [Vacio]";
    }

    void useObject(string objetive)
    {
        GameObject objetiveO = GameObject.FindGameObjectWithTag(objetive);
        objetiveO.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    { 
        this.currentObject = col.gameObject;

         texto.text = " Objeto = ["+col.tag+"]";

        accionesObjetos = new AccionesObjetos(col.tag, this.player, this.currentObject, this.texto);
        accionesObjetos.checkTag();
    }

    void OnTriggerExit2D(Collider2D col)
    {
            this.currentObject = null;  
            texto.text = "Objeto = [Vacio]";
    }

    bool RayCast(string objetive)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right,3.0f);

        if (hit.collider != null) 
        {
            Debug.Log("Distance: " + (hit.point.x - transform.position.x));
            return hit.collider.tag.Equals(objetive);
        }
        return false;
    }


}
