using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Script : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;

    public GameObject pieces; 

    // Initialize the point we need to win
    void Start()
    {
        pointsToWin = pieces.transform.childCount;        
    }

    // Make the win menu visible when points to win are reached
    void Update()
    {
        if(currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    // Add points for each corect piece
    public void AddPoint()
    {
        currentPoints++;
    }
}
