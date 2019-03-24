using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonAventuraScript : MonoBehaviour
{
    public Button avent;
    
    public void Start()
    {
       Button av = avent.GetComponent<Button>();
       av.onClick.AddListener(click);
    }

    void click()
    {
        SceneManager.LoadScene("Aventura");
    }  
    
}
