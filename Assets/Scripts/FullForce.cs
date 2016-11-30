using UnityEngine;
using System.Collections;

public class FullForce : MonoBehaviour {
    public float force = 50.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ConstantForce>())
        {
            var cf = other.gameObject.GetComponent<ConstantForce>();
            cf.force.Set(force, 0.0f, 0.0f);
            cf.enabled = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<ConstantForce>())
        {
            var cf = other.gameObject.GetComponent<ConstantForce>();
            cf.force.Set(0.0f, 0.0f, 0.0f);
            cf.enabled = false;
        }
    }
}
