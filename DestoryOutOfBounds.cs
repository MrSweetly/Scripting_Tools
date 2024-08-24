using System;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    public float lowBound;
    public float topBound;

    private GameManager gameManager;

    void Start()
    {
        // Looks for the game object Game Manager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        // Boundery contraints for Z range (Interchangable)
        // Destroy object when out of top bound
        if (transform.position.z > topBound) {
            Destroy(gameObject); }
        // Destroy object when out of low bound
        else if (transform.position.z < lowBound) {
            Destroy(gameObject); }
    }
}
