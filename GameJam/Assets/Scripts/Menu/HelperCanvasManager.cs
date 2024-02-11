using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperCanvasManager : MonoBehaviour
{
    public GameObject Helpercanvas;
    
    public void Update()
    {
        if(Input.GetKey(KeyCode.K))
        {
            Helpercanvas.SetActive(false);
        }
    }
}
