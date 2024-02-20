using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeedZ;
    public float rotateSpeedX;
    public float rotateSpeedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotateSpeedX * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateSpeedY * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotateSpeedZ * Time.deltaTime);
    }
}
