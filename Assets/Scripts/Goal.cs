using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger",other);
        //Destroy(other.gameObject);
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Bana1");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collission");
    }
}
