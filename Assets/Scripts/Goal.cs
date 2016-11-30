using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger",other);
        //Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collission");
    }
}
