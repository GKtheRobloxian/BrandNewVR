using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSmallerOverLifetime : MonoBehaviour
{
    public DestroyAfterCreate life;
    Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = scale - new Vector3((scale.x) / life.lifetime * Time.deltaTime, scale.y / life.lifetime * Time.deltaTime, scale.z / life.lifetime * Time.deltaTime);
    }
}
