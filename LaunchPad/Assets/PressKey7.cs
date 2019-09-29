using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKey7 : MonoBehaviour
{
    AudioSource Music;
    // Start is called before the first frame update
    void Start()
    {
        Music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            transform.localScale += new Vector3(2, 2, 0);
            Music.Play(0);
        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            transform.localScale -= new Vector3(2, 2, 0);
            Music.Stop();
        }
    }
}