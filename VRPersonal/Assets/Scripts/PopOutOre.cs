using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
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

    }

    public void PopOre()
    {
        GameObject ore = Instantiate(orePiece, (oreCrack.transform.position) + new Vector3(oreCrack.transform.position.x - transform.position.x, oreCrack.transform.position.y - transform.position.y, oreCrack.transform.position.z - transform.position.z) * 0.2f, Quaternion.identity);
        ore.GetComponent<Rigidbody>().AddTorque(Vector3.right * Random.Range(-10f, 10f) + Vector3.up * Random.Range(-10f, 10f) + Vector3.forward * (Random.Range(-10f, 10f)));
        ore.GetComponent<Rigidbody>().AddForce((ore.transform.position - transform.position).normalized * forceOut, ForceMode.Impulse);
        ore.GetComponent<SetMaterial>().piece = true;
        foreach (GameObject metal in ore.GetComponent<SetMaterial>().metals)
        {
            metal.GetComponent<MeshRenderer>().material = GetComponent<SetMaterial>().currentColor;
        }
    }
}
