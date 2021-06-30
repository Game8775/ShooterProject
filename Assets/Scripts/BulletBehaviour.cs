using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public Rigidbody _rigidbody;
    public float _speed=20f;
	// Use this for initialization
	void Start () {
        _rigidbody.velocity = Vector3.up * _speed;
    }
	


   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish" || other.tag=="warship")
        {
            Destroy(gameObject);
        }

    }
}
