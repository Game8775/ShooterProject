using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidBehaviour : MonoBehaviour
{

    int life = 8;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 3 * Time.deltaTime, Space.World);
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
                GameManager.Instance.Score += 2;
                Destroy(gameObject);
            }
        }
    }
}
