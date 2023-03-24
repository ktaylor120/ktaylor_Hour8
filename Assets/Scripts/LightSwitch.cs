using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light lightBulb;
    // Start is called before the first frame update
    void Start()
    {
        lightBulb = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp (KeyCode.L))
        {
            lightBulb.enabled = !lightBulb.enabled;
        }
    }
}
