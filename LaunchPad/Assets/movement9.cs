using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement9 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.O))
        {
            visible.enabled = true;
            transform.position = new Vector3(8*Mathf.Cos(Time.time), 0, 0);
            transform.Rotate(80 * Time.deltaTime, 0, 0);
        }
        else { visible.enabled = false; }
    }
}
