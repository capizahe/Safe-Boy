using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonPreguntados : MonoBehaviour
{
    public Button Preg;

     void Start()
    {
        Button p = Preg.GetComponent<Button>();
        p.onClick.AddListener(click);
    }

    void click()
    {
        SceneManager.LoadScene("Preguntados");
    }
}
