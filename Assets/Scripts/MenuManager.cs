using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI scoreBoardText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreBoardText.text =  GameManager.instance.highScore.ToString();
    }

    public void StartEasy()
    {
        GameManager.instance.spawnSpeed = 1f;
         SceneManager.LoadScene("GamePlay");
        
    }

    public void StartMedium()
    {
        
        GameManager.instance.spawnSpeed = 0.8f;
         SceneManager.LoadScene("GamePlay");
    }
    
    public void StartHard()
    {
        
        GameManager.instance.spawnSpeed = 0.6f;
         SceneManager.LoadScene("GamePlay");
    }
    
}
