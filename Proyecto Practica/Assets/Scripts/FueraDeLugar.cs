using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FueraDeLugar : MonoBehaviour
{

    public GameObject player;
    private bool isIn;

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
        this.isIn = (player.transform.position.y < -5 && player.transform.position.x > 8) ? false : true;
        return this.isIn;
    }
    /*
     *Este metodo pondra el personaje nuevamente en su posicion inicial. 
     */
    void restartPosition()
    {
        player.transform.position = new Vector3(-6.98f, -3f, -3.469688f);
        this.isIn = true;
    }
}
