using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if(transform.position.x < -10) 
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        if(transform.position.x > 10) 
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        if (transform.position.z < 0)
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (transform.position.z > 3)
            transform.position = new Vector3(transform.position.x, transform.position.y, 3);
    }
}
