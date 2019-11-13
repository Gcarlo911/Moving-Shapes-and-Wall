using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChildMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //////////////Variables/////////////////////////////////////////////////////////////////////////////////////
        float clock;
        Transform plane1;                  
        Transform plane2;
        Transform plane3;
        Transform plane4;
        plane1 = transform.GetChild(0);
        plane2 = transform.GetChild(1);
        plane3 = transform.GetChild(2);
        plane4 = transform.GetChild(3);
        //////////////Variables/////////////////////////////////////////////////////////////////////////////////////





        //////////////The Stuff I'm Doing///////////////////////////////////////////////////////////////////////////
        MoveTransformLeft(plane1);
        MoveTransformRight(plane2);
        MoveTransformUp(plane3);
        MoveTransformDown(plane4);
        Debug.Log(RandomAdding(456, 87));

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

        }
        //////////////The Stuff I'm Doing///////////////////////////////////////////////////////////////////////////










        //////////////Functions/////////////////////////////////////////////////////////////////////////////////////
        void MoveTransformLeft(Transform theThing)
        {
            theThing.position += Vector3.left * Time.deltaTime * 5;
        }

        void MoveTransformUp(Transform theThing)
        {
            theThing.position += Vector3.up * Time.deltaTime * 5;
        }

        void MoveTransformDown(Transform theThing)
        {
            theThing.position += Vector3.down * Time.deltaTime * 5;
        }

        void MoveTransformRight(Transform theThing)
        {
            theThing.position += Vector3.right * Time.deltaTime * 5;
        }

        int RandomAdding(int N1, int N2)
        {
            return N1 + N1;
        }

    }   //////////////Functions/////////////////////////////////////////////////////////////////////////////////////
}
