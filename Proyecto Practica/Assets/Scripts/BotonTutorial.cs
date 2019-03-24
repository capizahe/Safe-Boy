using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BotonTutorial : MonoBehaviour
{
    public Button Tut;

    public void Start()
    {
        Button t = Tut.GetComponent<Button>();
        t.onClick.AddListener(click);
    }

    void click()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
