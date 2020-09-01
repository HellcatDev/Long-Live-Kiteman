using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform edgePoint;
    [Range(0f, 15f)]
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.right * rotateSpeed * Time.deltaTime);
        }
    }
}
