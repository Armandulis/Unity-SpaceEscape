using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int highScore = 0;
    public float spawnSpeed = 1;
    private GameObject player;
    public int score = 0;
    public TextMeshProUGUI scoreBoardText;

    public static GameManager instance;

    private void Awake() {
        if( !instance )
        {
            instance = this;
            DontDestroyOnLoad( gameObject );
        }
        else
        {
            Destroy( gameObject );
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( CalculateScore() );
    }

    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.FindWithTag( "Player" );
        
        scoreBoardText = GameObject.FindObjectsOfType<TextMeshProUGUI>()[1];
    }

     IEnumerator CalculateScore()
    {
        while( true )
        { 
             yield return new WaitForSeconds( 1 );
            if(player)
            {

             score++;    
            scoreBoardText.text = score.ToString();
                if(score > highScore )
                {
                    highScore = score;
                }
            }
        }
    }
}
