using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColors : MonoBehaviour
{
    MeshRenderer mesh;
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
        // 7 renk var, 8 ye kadar olaný alýr
        int random = Random.Range(1, 8);

        switch (random)
        {
            case 1:
                mesh.material = Yellow;
                break;
            case 2:
                mesh.material = Blue;
                break;
            case 3:
                mesh.material = Purple;
                break;
            case 4:
                mesh.material = Green;
                break;
            case 5:
                mesh.material = Orange;
                break;
            case 6:
                mesh.material = Red;
                break;
            case 7:
                mesh.material = Black;
                break;

        }

    }
}
