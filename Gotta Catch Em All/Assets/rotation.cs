using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
 
    void Update()
    {
        // Time.deltaTime*100 will make sure we are moving at a constant speed of 100 per second
        transform.Rotate(0f, 0f, Time.deltaTime * 100);
    }
}
