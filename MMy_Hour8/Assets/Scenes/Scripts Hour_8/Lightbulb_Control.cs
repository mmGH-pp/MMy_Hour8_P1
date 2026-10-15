using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb_Control : MonoBehaviour
{
    // Start is called before the first frame update
 
    Light myLight;

    void Start()
    {

    myLight = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))

      {
        myLight.enabled = !myLight.enabled;

      }
    }
}
