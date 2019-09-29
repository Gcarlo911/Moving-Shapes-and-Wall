using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour


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
        if (Input.GetKey(KeyCode.W))
        {
            visible.enabled = true;
            transform.position = new Vector3(9 * Mathf.Sin(3*Time.time), 2 * Mathf.Cos(Time.time * 4), 0);
        }
        else { visible.enabled = false; }
    }
}
