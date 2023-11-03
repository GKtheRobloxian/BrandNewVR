using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{

    public GameObject[] metals;
    public Material[] coloring;
    // Start is called before the first frame update
    void Start()
    {
        int randomMaterial = Random.Range(0, coloring.Length);
        for(int i = 0; i < metals.Length; i++)
        {
            metals[i].GetComponent<MeshRenderer>().material = coloring[randomMaterial];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
