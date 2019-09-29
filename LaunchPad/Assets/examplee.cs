using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examplee : MonoBehaviour

    
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
        if (Input.GetKey(KeyCode.Q))
        {
            visible.enabled = true;
            transform.position = new Vector3(5 * Mathf.Sin(Time.time*2), 5 * Mathf.Cos(Time.time*3), 0);
        }
        else { visible.enabled = false; }
        }
}
