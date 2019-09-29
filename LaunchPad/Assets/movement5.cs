using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement5 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.T))
        {
            visible.enabled = true;
        }
        else { visible.enabled = false; }
    }
}
