using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColors : MonoBehaviour
{
    private MeshRenderer mesh;
    public Material Black, Blue, Green, Orange, Purple, Red, Yellow;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        GiveColor();
        
    }
    void Update()
    {
        
    }

    void GiveColor()
    {
        // 6 renk var, 7 ye kadar olaný alýr
        int random = Random.Range(1, 7);
        Debug.Log(random);

    }
}
