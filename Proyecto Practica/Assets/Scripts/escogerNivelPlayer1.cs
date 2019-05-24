using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscogerNivelPlayer1 : MonoBehaviour
{

    public static EscogerNivelPlayer1 escogerNivel { get; private set; }

  
    public Vector3 posLevel1;
    public Vector3 posLevel2;
    public Vector3 posLevel3;
    public Vector3 posFinal;


    public  GameObject currentPosition;

    private void Awake()
    {
        posLevel1 = new Vector3(-7.37f, 4.59f, -3.560819f);
        posLevel2 = new Vector3(-6.09f, 3.57f, -3.560819f);
        posLevel3 = new Vector3(-4.56f, 2.33f, -3.560819f);
        posFinal  = new Vector3(-0.65f, 0.21f, -3.560819f);


        if (escogerNivel == null)
        {
        escogerNivel = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(currentPosition!=null)
            if (this.currentPosition.transform.Equals(posFinal))
            {

            }
            
    }


    public void ChangeToLevel()
    {

        currentPosition = GameObject.FindGameObjectWithTag("JugadorAventura");
        Vector3 actualLevel = currentPosition.transform.position;
            Debug.Log("Actual level "+ actualLevel);
            Debug.Log("Actual pos "  + posLevel1);
        DontDestroyOnLoad(currentPosition);

        if (actualLevel.x.Equals(posLevel1.x) && actualLevel.y.Equals(posLevel1.y))
            { SceneManager.LoadScene("EscenaNivel1"); Debug.Log("Entro a Escena Nivel 1"); }
            else if (actualLevel.x.Equals(posLevel2.x) && actualLevel.y.Equals(posLevel2.y))
            { SceneManager.LoadScene("EscenaNivel2"); Debug.Log("Entro a Escena Nivel 2"); }
            else if (actualLevel.x.Equals(posLevel3.x) && actualLevel.y.Equals(posLevel3.y))
            { SceneManager.LoadScene("EscenaNivel3"); Debug.Log("Entro a Escena Nivel 3"); }
    }
    public void ActualPosition(Vector3 actualPosition )
    {
        currentPosition = GameObject.FindGameObjectWithTag("JugadorAventura");

        Debug.Log("The last position is " + currentPosition.transform);
        currentPosition.transform.position = actualPosition;
        Debug.Log("The new position is " +currentPosition.transform);

    }


}
