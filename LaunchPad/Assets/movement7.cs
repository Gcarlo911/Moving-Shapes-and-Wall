using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement7 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -300);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            transform.position = new Vector3(0, 0, -30);
        }
        else { transform.position = new Vector3(0, 0, -300); }
    }
}
