using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreRotation : MonoBehaviour
{
    public Transform centrePoint;
    public Transform edgePoint;
    [Range(0f, 15f)]
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        edgePoint.transform.SetParent(centrePoint);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
