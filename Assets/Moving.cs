using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public static Vector2 direction;
    internal static bool isMoving = true;

    void Start()
    {
        direction = new Vector2(0, 3);
        StartCoroutine(Move());
    }
    //void Update()
    //{
    //    if(isMoving)
            
    //}
    private IEnumerator Move()
    {
        while (isMoving)
        {
            transform.Translate(direction * Time.deltaTime);
            yield return null;
        }
    }
    private void OnTriggerEnter()
    {
        //direction = new Vector2(2, 0);
        isMoving = false;
        print("AAAAAAAAAAAAAA");
        Debug.Log("AaAAAAAAA");

    }
}
