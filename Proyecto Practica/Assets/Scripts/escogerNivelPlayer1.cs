using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escogerNivelPlayer1 : MonoBehaviour
{

    private Vector3 posLevel1 = new Vector3(-6.04f, 4.5f, -3.56081f);
    private Vector3 posLevel2 = new Vector3(-4.98f,3.9f, -3.6f);
    private Vector3 posLevel3 = new Vector3(-3.75f,2.28f,-3.6f);


    public GameObject currentPosition;


    public void ChangeToLevel()
    {
        
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


}
