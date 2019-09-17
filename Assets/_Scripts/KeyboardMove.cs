using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public float sensitivity = 15F;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * sensitivity,
            0.0f,
            Input.GetAxis("Vertical") * sensitivity);    
    }
}
