using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement4 : MonoBehaviour
{
    public Renderer visible;
    // Start is called before the first frame update
    void Start()
    {
        visible = GetComponent<Renderer>();
        visible.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            visible.enabled = true;
            transform.position = new Vector3(8 * Mathf.Sin(Time.time), 2 * Mathf.Cos(Time.time * 3), 0);
            transform.Rotate(1, 6 * Time.deltaTime, 1);
        }
        else { visible.enabled = false; }
        
    }
}
