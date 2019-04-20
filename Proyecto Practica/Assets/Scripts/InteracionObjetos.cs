using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
                this.hasObject = true;
                this.currentObject.SetActive(false);
                this.grabbedObject = this.currentObject;
                Debug.Log("The grabbed object is -> " + this.currentObject.tag);
            }
            else
            {
                Debug.Log("The object -> " + this.currentObject.tag + " is not grabbable.");
            }
        }
        if (Input.GetKey(KeyCode.Z) && this.hasObject && this.grabbedObject)
        {
            this.grabbedObject = null;
            this.currentObject.SetActive(true);
            this.currentObject = null;
            this.hasObject = false;
            texto.text = "Objeto = [Vacio]";
        }


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
        if (this.currentObject != null)
        {
            this.currentObject = null;
        }
       
            texto.text = "Objeto = [Vacio]";
    }
   


}
