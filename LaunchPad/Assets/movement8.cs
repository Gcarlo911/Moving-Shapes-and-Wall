using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement8 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.I))
        {
            visible.enabled = true;
            transform.position = new Vector3(0, 40 * Mathf.Cos(Time.time), 0);
        }
        else { visible.enabled = false; }
    }
}
