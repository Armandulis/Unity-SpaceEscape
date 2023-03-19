using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudioManager : MonoBehaviour
{
    public AudioSource audioData;



private void Awake() {
    
        // Debug.Log("WTF");
        // GetComponent<AudioSource>().Play();
}

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("WTF");
// audioData.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound( AudioSource audio ){
        audio.Play();
    }
}
