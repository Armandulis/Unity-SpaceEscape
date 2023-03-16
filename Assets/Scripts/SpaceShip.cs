using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        updatePosition();
    }

    public void updatePosition()
    {
        Vector2 originalPosition = transform.position;

        // Place Player on new position
        float h = Input.GetAxisRaw( "Horizontal" );
        float v = Input.GetAxisRaw( "Vertical" );
        
        Vector2 position = transform.position;
        position.x += h * Time.deltaTime * 10;
        position.y += v * Time.deltaTime * 10;

        transform.position = position;

        // Check if player position is valid
        Vector2 poss = Camera.main.WorldToViewportPoint(transform.position);
 
        // If Position is outside of camera, correct player's position
        Vector2 correctedPosition = transform.position;
        if(poss.x - 0.1 < 0.0 || 1.0 <  0.1 + poss.x) 
        {
            correctedPosition.x = originalPosition.x;
        }
        if(poss.y - 0.05< 0.0 || 1.0 < 0.05 + poss.y)
        {
            correctedPosition.y = originalPosition.y;
        }
    
        transform.position = correctedPosition;
   }
}
