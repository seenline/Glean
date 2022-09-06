using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("d"))
        {
            position.x = position.x + 0.1f;
        }
        if (Input.GetKey("a"))
        {
            position.x = position.x - 0.1f;
        }
        if (Input.GetKey("s"))
        {
            position.y = position.y - 0.1f;
        }
        if (Input.GetKey("w"))
        {
            position.y = position.y + 0.1f;
        }

        transform.position = position;
    }
}