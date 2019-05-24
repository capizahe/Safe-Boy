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
    public GameObject scenary; // Esta variable se usa para saber en que escenario esta


    //Variables nivel 1 Escena 2
    bool closed = false;
    public Animator anim;


    void Start()
    {
        texto.text = "Objeto = [Vacio]";
    }

     void Update()
    {
        //Nivel 1 escena 2
        if (this.scenary.tag.Equals("cocina"))
        {
        anim.SetBool("UsaRegistro", false);
        }

        if (Input.GetKey(KeyCode.Space) && this.currentObject && !this.hasObject && !this.grabbedObject 
                                        && !accionesObjetos.isJustUsable(this.currentObject.tag))
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
        if (Input.GetKey(KeyCode.Z) && this.hasObject && this.grabbedObject && !accionesObjetos.isJustUsable(this.currentObject.tag))
        {
            dropObject();
        }
        if (Input.GetKey(KeyCode.X) && this.hasObject && this.grabbedObject  && (RayCast("fuego") || (RayCast("fuegoL2"))))
        {

            //Nivel 1 escena 2
            if (this.scenary.tag.Equals("cocina"))
            {
                //Si el registro esta cerrado
                if (closed)
                {
                    useObject("fuegoL2");
                    SceneManager.LoadScene("MapaPrincipalAventura");
                    EscogerNivelPlayer1.escogerNivel.ActualPosition(EscogerNivelPlayer1.escogerNivel.posLevel3);
                }
            }

            if (this.scenary.tag.Equals("Sala"))
            {
                //Si el registro esta cerrado
                    useObject("fuego");
                    SceneManager.LoadScene("MapaPrincipalAventura");
                    EscogerNivelPlayer1.escogerNivel.ActualPosition(EscogerNivelPlayer1.escogerNivel.posFinal);
                    Object.Destroy(EscogerNivelPlayer1.escogerNivel);
               
            }

            //Nivel 1 escena 1

            if (this.scenary.tag.Equals("habitacion"))
            {
                useObject("fuego");
                if (EscogerNivelPlayer1.escogerNivel.currentPosition != null)
                { 
                    SceneManager.LoadScene("MapaPrincipalAventura");
                    EscogerNivelPlayer1.escogerNivel.ActualPosition(EscogerNivelPlayer1.escogerNivel.posLevel2);
                }
            }

        }
        //Verifica que el objeto de mano si no un objeto tan solo usable
        if(Input.GetKey(KeyCode.X) && !this.hasObject && this.currentObject && accionesObjetos.isJustUsable(this.currentObject.tag))
        {
            Debug.Log("usando "+ this.currentObject.tag);
            anim.SetBool("UsaRegistro",true);
            closed = true;
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
        Debug.Log("El objetivo es " + objetive);
        GameObject objetiveO = GameObject.FindGameObjectWithTag(objetive);
        objetiveO.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    { 

        this.currentObject = col.gameObject;
        texto.text = " Objeto = [" + col.tag + "]";
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
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, -Vector2.right, 3.0f);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, -Vector2.left, 3.0f);
        if (hitRight.collider != null)
            {
                Debug.Log("Distance: " + (hitRight.point.x - transform.position.x));
                return hitRight.collider.tag.Equals(objetive);
            }
        
        if (hitLeft.collider != null)
        {
            Debug.Log("Distance: " + (hitLeft.point.x - transform.position.x));
            return hitLeft.collider.tag.Equals(objetive);
        }
        return false;

    }


}
