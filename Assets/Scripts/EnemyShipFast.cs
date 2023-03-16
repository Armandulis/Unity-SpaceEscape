using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipFast : MonoBehaviour
{
    private int speedMin = 6;
    private int speedMax = 12;

    private int speed = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range( speedMin, speedMax );
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 position = transform.position;
        position.y = position.y -  Time.deltaTime * speed;
        transform.position = position;
    }
}
