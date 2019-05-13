using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escogerNivelPlayer1 : MonoBehaviour
{

    public escogerNivelPlayer1 escogerNivel;

    public  Vector3 posLevel1 = new Vector3(-6.04f, 4.5f, -3.6f);
    public  Vector3 posLevel2 = new Vector3(-4.98f,3.5f, -3.6f);
    public  Vector3 posLevel3 = new Vector3(-3.75f,2.28f,-3.6f);
    public bool nivel1Superado = false;


    public  GameObject currentPosition;

    private void Start()
    {
        posLevel1 = new Vector3(-6.04f, 4.5f, -3.6f);
        posLevel2 = new Vector3(-4.98f, 3.5f, -3.6f);
        posLevel3 = new Vector3(-3.75f, 2.28f, -3.6f);
        escogerNivel = this;
    }


    public void ChangeToLevel()
    {
        currentPosition = GameObject.FindGameObjectWithTag("JugadorAventura");
        DontDestroyOnLoad(currentPosition);
        Vector3 actualLevel = currentPosition.transform.position;
            Debug.Log(actualLevel);
            Debug.Log(posLevel1);
            if (actualLevel.x.Equals(posLevel1.x) && actualLevel.y.Equals(posLevel1.y))
            { SceneManager.LoadScene("EscenaNivel1"); Debug.Log("Entro a Escena Nivel 1"); }
            else if (actualLevel.x.Equals(posLevel2.x) && actualLevel.y.Equals(posLevel2.y))
            { SceneManager.LoadScene("EscenaNivel2"); Debug.Log("Entro a Escena Nivel 2"); }
            else if (actualLevel.x.Equals(posLevel3.x) && actualLevel.y.Equals(posLevel3.y))
            { SceneManager.LoadScene("EscenaNivel3"); Debug.Log("Entro a Escena Nivel 3"); }
    }
    public void ActualPosition(Vector3 actualPosition )
    {
        currentPosition.transform.position.Set(actualPosition.x,actualPosition.y,actualPosition.z);

    }


}
