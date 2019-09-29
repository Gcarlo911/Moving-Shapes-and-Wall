using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasstuff : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.GetComponent<Canvas>().enabled = true;
        canvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            canvas.enabled = false;
            

        }
        else {  }
    }
}
