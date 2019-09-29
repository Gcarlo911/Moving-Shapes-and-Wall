using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement3 : MonoBehaviour


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
        if (Input.GetKey(KeyCode.E))
        {
            visible.enabled = true;
            transform.position = new Vector3(7 * Mathf.Sin(Time.time*10), 5 * Mathf.Cos(Time.time*12), 0);
        }
        else { visible.enabled = false; }
    }
}
