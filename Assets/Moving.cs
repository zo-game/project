using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Vector2 direction;
    public int Speed;
    public GameObject Player;
    private bool isMoving = true;

    void Update()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
        //var routine = Move();
        //if (true)
        //StartCoroutine((IEnumerator)routine);
        //transform.Translate(direction * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //if (collider.tag == "Player")
        print("AAAAAAAAAAAAAA");
        Debug.Log("AaAAAAAAA");
            //Speed = 0;
        //isMoving = false;

    }
    //void OnCollisionEnter2D(Collision2D collider)
    //{
        
    //    print("AAAAAAAAAAAAAA");
    //    //Speed = 0;
    //    //isMoving = false;

    //}

    //public IEnumerable Move()
    //{
    //    //var time = new WaitForSeconds(0.01f);
    //    //while (isMoving)
    //    for(var i = 0; i < 10; i++)
    //    {
    //        Player.transform.Translate(direction * Time.deltaTime * Speed);
    //        yield return new WaitForSeconds(0.01f);
    //    }

    //    //Debug.Log("Movement done");
    //}
}
