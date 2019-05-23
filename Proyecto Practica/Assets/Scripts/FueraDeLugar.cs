using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FueraDeLugar : MonoBehaviour
{

    public GameObject player;
    private bool isIn;
    public GameObject scenary;


    void Start()
    {
        this.isIn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!check())
        {
            restartPosition();
        }
    }

    /*
     *Este metodo verifica que el personaje no haya salido por la ventana 
     */
    bool check()
    {
        this.isIn = ((player.transform.position.y < -5 && player.transform.position.x > 8)
                   ||(player.transform.position.y < -4))  ? false : true;
        return this.isIn;
    }
    /*
     *Este metodo pondra el personaje nuevamente en su posicion inicial. 
     */
    void restartPosition()
    {
        switch (this.scenary.tag)
        {
            case "cocina":
                player.transform.position = new Vector3(-4.5f, -1.16f, -3.469688f);
                break;
            case "habitacion":
                player.transform.position = new Vector3(4.82f, -2.57f, -3.469688f);
                break;


        }

        if (this.scenary.tag.Equals("cocina"))
        {

        }
        if (this.scenary.tag.Equals("habitacion"))
        {
            player.transform.position = new Vector3(4.82f, -2.57f, -3.469688f);
        }
        this.isIn = true;

    }
}
