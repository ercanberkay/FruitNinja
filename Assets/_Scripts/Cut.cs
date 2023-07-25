using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private Manager manager;

    void Start()
    {
        manager = GameObject.FindObjectOfType<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            Destroy(collision.gameObject);
            manager.score++;
        }
        else if (collision.gameObject.tag == "Bomb")
        {
            manager.RestartGame();
        }
    }
}
