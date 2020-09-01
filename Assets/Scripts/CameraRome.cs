using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRome : MonoBehaviour
{
    public Transform target;
    [Range(0f, 1f)]
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.right * rotateSpeed * Time.deltaTime);
    }
}
