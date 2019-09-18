using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingThing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1 * Time.deltaTime * speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1 * Time.deltaTime * speed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1 * Time.deltaTime * speed, 0, 0);

        if (Input.GetKey(KeyCode.B))
        {
            transform.position += new Vector3(0, 0, -1 * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {       
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime * speed);
        }
        }
    }
}
