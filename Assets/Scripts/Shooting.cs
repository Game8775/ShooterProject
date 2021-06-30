using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject _player;
    public GameObject _fire;
    public GameObject _bullet;
  

    Vector3 _firePos;
    Vector3 _bullet1Pos;
    Vector3 _bullet2Pos;
	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot()
    {
        _firePos = _player.transform.position;
        _bullet1Pos = _player.transform.position;
        _bullet2Pos = _player.transform.position;

        _firePos.y = _player.transform.position.y - 1;
        _bullet1Pos.x = _player.transform.position.x - 1;
        _bullet2Pos.x = _player.transform.position.x + 1;

        Instantiate(_bullet,_bullet1Pos, _player.transform.rotation);
        Instantiate(_bullet, _bullet2Pos, _player.transform.rotation);
        GameObject b= Instantiate(_fire, _firePos, _player.transform.rotation);
        Destroy(b, 0.02f);
    }
}
