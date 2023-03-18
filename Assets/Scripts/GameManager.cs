using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    public int score = 0;
    public TextMeshProUGUI scoreBoardText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag( "Player" );
        StartCoroutine( CalculateScore() );
    }

    // Update is called once per frame
    void Update()
    {
        
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
            }
        }
    }
}
