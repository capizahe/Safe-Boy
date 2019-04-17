using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCamara : MonoBehaviour
{
    //public Camera mn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //Camera.main.transform.Translate(Input.GetAxisRaw("Horizontal") * 10, Input.GetAxisRaw("Vertical") * 10, 0);
       Camera.main.transform.Translate(Input.GetAxisRaw("Horizontal") * 1, Input.GetAxisRaw("Vertical") * 1, 0);
        
    }
}
