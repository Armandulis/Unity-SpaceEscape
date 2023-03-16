using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipBig : MonoBehaviour
{
    private int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y = position.y -  Time.deltaTime * speed;
        transform.position = position;
    }
}
