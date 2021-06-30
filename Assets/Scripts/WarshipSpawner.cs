using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarshipSpawner : MonoBehaviour {

    public GameObject warship;
    public GameObject warship2;
    public GameObject asteroid;
    public GameObject heart;
    public GameObject warshipBullet;
    
    Vector3 _warshipPos;
	// Use this for initialization
	public void StartSpawning() {
        _warshipPos = transform.position;
        _warshipPos.z = 0;
        _warshipPos.y = 6;

        InvokeRepeating("WarshipGenerate", 2.0f, 2f);
        InvokeRepeating("Warship2Generate", 6.0f, 10f);
        InvokeRepeating("AsteroidGenerate", 15.0f, 20f);
        InvokeRepeating("LifesGenerate", 7f, 10f);
    }
  

    void WarshipGenerate()
    {
        if (GameManager.Instance.Lives > 0)
        {
            _warshipPos.x = Random.Range(-4, 4);
            Instantiate(warship, _warshipPos, warship.transform.rotation);
        }
    }

    void Warship2Generate()
    {
        if (GameManager.Instance.Lives > 0 )
        {
            _warshipPos.x = Random.Range(-3, 3);
            Instantiate(warship2, _warshipPos, warship.transform.rotation);
        }
    }

    void AsteroidGenerate()
    {
        if (GameManager.Instance.Lives > 0 )
        {
            _warshipPos.x = Random.Range(-3, 3);
            Instantiate(asteroid, _warshipPos, warship.transform.rotation);
        }
    }

    void LifesGenerate()
    {
        _warshipPos.x = Random.Range(-3, 3);
        Instantiate(heart, _warshipPos,warship.transform.rotation);
    }


}
