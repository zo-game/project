using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("GGGGGGGG");
        print("gggggg");
    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log("GGGGGGGG");
        print("gggggg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
