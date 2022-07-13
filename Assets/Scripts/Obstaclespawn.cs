using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject objecttospawn;
    [SerializeField]
    int numberOfItems;

    private void Start()
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            Vector3 position = new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(4f, -3.4f), Random.Range(4.6f, -4.6f));
            Instantiate(objecttospawn, position, Quaternion.identity);

        }
    }
}
