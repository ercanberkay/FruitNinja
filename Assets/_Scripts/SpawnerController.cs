using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float minX, maxX, startTime;
    [SerializeField] Sprite[] sprites;
    float time;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (time <= 0)
        {
            SpawnObject();
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    void SpawnObject()
    {
        GameObject newPrefab = Instantiate(prefab);
        newPrefab.transform.position = new Vector2(
            Random.Range(minX, maxX),
            transform.position.y
            );

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
