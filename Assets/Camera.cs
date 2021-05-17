using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    [SerializeField] private int cameraSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        if (this.objectToFollow == null)
        {
            this.objectToFollow = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        }

        this.transform.position = new Vector3()
        {
            x = this.objectToFollow.position.x,
            y = this.objectToFollow.position.y + 2,
            z = this.objectToFollow.position.z - 10
        };
    }

    private void Update()
    {
        if (this.objectToFollow)
        {
            var target = new Vector3()
            {
                x = this.objectToFollow.position.x,
                y = this.objectToFollow.position.y,
                z = this.objectToFollow.position.z - 10
            };

            var newPos = Vector3.Lerp(this.transform.position, target, this.cameraSpeed * Time.deltaTime);

            this.transform.position = newPos;
        }
    }
}