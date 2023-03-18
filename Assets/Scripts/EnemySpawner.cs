using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemiesList;

    private float mostLeftPosition;
    private float mostRightPosition;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 cameraPositionBottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        mostLeftPosition = cameraPositionBottomLeft.x;

        
        Vector2 cameraPositionTopRight = Camera.main.ScreenToWorldPoint(Vector2.zero);
        mostRightPosition = cameraPositionTopRight.x;


        StartCoroutine( SpawnEnemies() );
    }

    IEnumerator SpawnEnemies()
    {
        while( true )
        {
            yield return new WaitForSeconds( GameManager.instance.spawnSpeed );

            int enemyIndex = Random.Range( 0, enemiesList.Length );
            GameObject spawnedEnemy = Instantiate( enemiesList[ enemyIndex ] );

            Vector2 enemyPostion = spawnedEnemy.transform.position;
            enemyPostion.x = Random.Range( mostLeftPosition, mostRightPosition );
            spawnedEnemy.transform.position = enemyPostion;
        }
    }
}
