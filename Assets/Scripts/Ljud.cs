using UnityEngine;
using System.Collections;

public class Ljud : MonoBehaviour
{
    public AudioClip boing;

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = boing;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger", other);
        //Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collission");
        GetComponent<AudioSource>().Play();

    }
}
