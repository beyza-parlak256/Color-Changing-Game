using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public MeshRenderer square1, square2;

    void Update()
    {
        if(square1.material.name == square2.material.name)
        {
            Debug.Log("You win, the colors are the same...");
            Time.timeScale = 0;
        }
    }
}
