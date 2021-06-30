using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warship2Behaviour : MonoBehaviour {

    int life = 5;
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 5 * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "finish")
        {
            GameManager.Instance.Lives--;
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

        if (collider.tag == "bullet")
        {
            life--;
            if (life == 0)
            {   
                GameManager.Instance.Score +=2;
                Destroy(gameObject);
            }
        }
    }
}
