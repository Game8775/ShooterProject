using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarshipBehaviour : MonoBehaviour {



    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.down *7*Time.deltaTime, Space.World);
      
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
            GameManager.Instance.Score ++;
            Destroy(gameObject);
        }
    }
   
}
