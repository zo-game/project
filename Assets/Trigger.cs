using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter() 
    {
        Moving.isMoving = false;
    }

    // Update is called once per frame
}
