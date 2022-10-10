using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColors : MonoBehaviour
{
    MeshRenderer mesh;
    public Material Black, Blue, Green, Orange, Purple, Gray, Red, Yellow;
    public AudioSource colorAudio;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        GiveColor();


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GiveColor();
            colorAudio.Play();
        }
    }

    void GiveColor()
    {
        // 8 renk var, 9 ye kadar olaný alýr
        int random = Random.Range(1, 9);

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
            case 8:
                mesh.material = Gray;
                break;

        }

    }
}
