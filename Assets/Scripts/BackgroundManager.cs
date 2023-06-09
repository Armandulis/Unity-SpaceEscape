using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;
    
    [SerializeField]
    private float offset;
    private Vector2 startPosition;
    private float newYPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;    
    }
    

    // Update is called once per frame
    void Update()
    {
        newYPosition = Mathf.Repeat( Time.time * -moveSpeed, offset );
        transform.position = startPosition + Vector2.up * newYPosition;
    }
}
