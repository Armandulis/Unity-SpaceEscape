using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipRandom : MonoBehaviour
{
    private int speed = 3;
    private int speedLeft = 4;
    private bool shouldGoSides = true;
    private int direction = -1;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        decideDirection();
        Vector2 originalPosition = transform.position;
        Vector2 position = transform.position;
        position.y = position.y -  Time.deltaTime * speed;
        if( shouldGoSides )
        {
            position.x = position.x - Time.deltaTime * speedLeft * direction ;
        }

        transform.position = position;


        Vector2 poss = Camera.main.WorldToViewportPoint(transform.position);
 
        // If Position is outside of camera, correct player's position
        Vector2 correctedPosition = transform.position;
        if(poss.x - 0.1 < 0.0 || 1.0 <  0.1 + poss.x) 
        {
            correctedPosition.x = originalPosition.x;
        }

        
        transform.position = correctedPosition;
    }

    private void decideDirection()
    {
        int randomSideIndex = Random.Range( 1, 101 );
        if( randomSideIndex > 1 )
        {
            shouldGoSides = true;

            int randomDirChoosed = Random.Range( 1, 3);
            if( randomDirChoosed == 1 )
            {
                direction = 1;
            }
            else
            {
                direction = -1;
            }
        }
        else
        {
            shouldGoSides = false;
        }
    }
}
