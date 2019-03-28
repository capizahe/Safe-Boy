using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CambioEscena: MonoBehaviour
{

    public string NombreEscena;

    public void on_Click()
    {
        SceneManager.LoadScene(this.NombreEscena);
    }

}

