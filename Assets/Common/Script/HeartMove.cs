using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMove : MonoBehaviour
{
    public float speed = 5f;
    private float buttomEdge;

    private void Start()
    {
        buttomEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y + 1f;
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.y < buttomEdge)
        {
            Destroy(gameObject);
        }
    }
}
