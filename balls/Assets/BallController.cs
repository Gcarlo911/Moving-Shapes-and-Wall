using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject Ball1;

    public GameObject Ball2;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ball1, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Ball2, new Vector3(1, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        float x;
        float y;
        x = 1;
        y = 1;

        
        if (Input.GetKeyDown(KeyCode.K)) {
            Ball1.transform.localScale += new Vector3(x*Time.deltaTime, y*Time.deltaTime, 0);
        }
        else Ball1.transform.localScale -= new Vector3(x * Time.deltaTime, y * Time.deltaTime, 0);

        if (x < 1)
        {
            Ball1.transform.localScale = new Vector3(1, 1, 0);
        }
    }
}
