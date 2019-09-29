using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement10 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.P))
        {
            visible.enabled = true;
            transform.position = new Vector3(50 * Mathf.Sin(Time.time*30), 0, 0);
           
        }
        else { visible.enabled = false; }
    }
}
