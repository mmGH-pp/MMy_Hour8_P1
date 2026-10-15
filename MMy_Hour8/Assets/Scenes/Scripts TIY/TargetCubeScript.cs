using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubeScript : MonoBehaviour


{
    // Start is called before the first frame update
    private GameObject target;
    
    void Start()
    {
        target = GameObject.FindWithTag("MyNewTag");
     target = GameObject.Find("Cube (1)");
    

    }

    // Update is called once per frame
    void Update()
    {
        // I changed it versus the book because I wanted to test out hte cords.

     target.transform.Translate(.05f, 0f, 0f);
     target.transform.Rotate(2f, 1f, 3f);
     target.transform.localScale = new Vector3(2.5f, 1.5f, 3.5f);
        
    }
}
