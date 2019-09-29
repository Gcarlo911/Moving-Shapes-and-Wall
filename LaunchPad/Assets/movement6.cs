using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement6 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.Y))
        {
            visible.enabled = true;
            transform.position = new Vector3(0, 0, 10*Mathf.Cos(Time.time * 4));
        }
        else { visible.enabled = false; }
    }
}
