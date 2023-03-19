using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{
    public AudioSource explosionAudio;

    private bool canMove = true;
    public GameObject explosion;
    private const string ENEMY_TAG = "Enemy";
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( canMove)
        {
            updatePosition();
        }
    }

    public void updatePosition()
    {
        
        Vector2 originalPosition = transform.position;

        // Place Player on new position
        if (Input.touchCount > 0)
        {
             Vector2 targetPosition = transform.position;
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
            }
                Vector2 position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                transform.position = position;
        }
        else
        {
             float h = Input.GetAxisRaw( "Horizontal" );
            float v = Input.GetAxisRaw( "Vertical" );
            
            Vector2 position = transform.position;
            position.x += h * Time.deltaTime * speed;
            position.y += v * Time.deltaTime * speed;

            transform.position = position;
        }

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

   private void OnTriggerEnter2D(Collider2D other) {

    GameObject explosion = Instantiate( this.explosion );
    explosion.transform.position = transform.position;

    if( other.CompareTag( ENEMY_TAG ) )
    {
        canMove = false;
        gameObject.SetActive( false );
        Destroy(gameObject, 3);
    }
    
   }

   private void OnDestroy() {
    
        SceneManager.LoadScene("MainMenu");
   }
}
