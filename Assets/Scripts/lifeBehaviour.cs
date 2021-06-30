using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeBehaviour : MonoBehaviour
{
    public Rigidbody _rigidbody;

    void Start()
    {
        transform.Rotate(0f, 0.0f, 180.0f, Space.Self);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 8 * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "player")
        {
            GameManager.Instance.Lives=GameManager.Instance.Lives+2;
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

        if (collider.tag == "finish")
        {
            Destroy(gameObject);
            
        }
    }
}
