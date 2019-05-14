using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0);
        anim.SetBool("isMoving", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isMoving", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.3481652f, -0.37f);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

            moveRight();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isMoving", true);
            transform.rotation = Quaternion.Euler(0, -180, 0);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-0.3693712f, -0.37f);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            moveLeft();
        }


        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("La posicion del jugador es "+gameObject.transform.position.y);
            if (gameObject.transform.position.y>= -2.9f && gameObject.transform.position.y <= -1f)
            {
                Debug.Log("entro en jump");
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));

                anim.SetBool("isJumping", true);
            }
            else
            {
                anim.SetBool("isJumping", false);

            }
        }
        else
        {
            anim.SetBool("isMoving", false);
            anim.SetBool("isJumping", false);


        }
        transform.rotation = Quaternion.Euler(0, 0, 0);

    }

    void moveRight()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(800f * Time.deltaTime, 0));

    }
    void moveLeft()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-800f * Time.deltaTime, 0));

    }
    void moveUp()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -100f));

    }
}
