using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float minX, maxX, minY, maxY, lifeTime;
    
    void Start()
    {
        RandomMove();
    }

    void RandomMove()
    {
        rb.velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY));

        Destroy(gameObject, lifeTime);
    }
}
