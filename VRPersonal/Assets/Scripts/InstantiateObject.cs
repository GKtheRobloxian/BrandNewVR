using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject objects;
    public Transform pointToTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Summon()
    {
        Instantiate(objects, pointToTransform.position, Quaternion.identity);
    }
}
