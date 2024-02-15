using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopOutOre : MonoBehaviour
{
    public GameObject orePiece;
    public GameObject oreCrack;
    public float forceOut;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        orePiece.GetComponent<SetMaterial>().coloring = GetComponent<SetMaterial>().coloring;
    }

    public void PopOre()
    {
        GameObject ore = Instantiate(orePiece, new Vector3(oreCrack.transform.localPosition.x * 1.1f, oreCrack.transform.localPosition.y * 1.1f, oreCrack.transform.localPosition.z * 1.1f), Quaternion.identity);
        ore.GetComponent<Rigidbody>().AddTorque(Vector3.right * Random.Range(-10f, 10f) + Vector3.up * Random.Range(-10f, 10f) + Vector3.forward * (Random.Range(-10f, 10f)));
        ore.GetComponent<Rigidbody>().AddForce((ore.transform.position - transform.position).normalized * forceOut, ForceMode.Impulse);
    }
}
