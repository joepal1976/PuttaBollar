using UnityEngine;
using System.Collections;

public class Uptrap : MonoBehaviour
{
    public float hoverForce;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger", other);
        //Destroy(other.gameObject);
        //GetComponent<AudioSource>().Play();

        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 700, ForceMode.Acceleration);
        //rb.AddForce(Vector3.back * -500, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collission");
    }
}
