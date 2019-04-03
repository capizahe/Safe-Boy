using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuSettings : MonoBehaviour
{

    public Button settings;

    // Start is called before the first frame update
    void Start()
    {

        Button s = settings.GetComponent<Button>();
        s.onClick.AddListener(click);
        
    }

    void click()
    {
        SceneManager.LoadScene("menuSettings");
    }


}
