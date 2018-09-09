using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Material matOfObject;
    public Color newcolo;
    public KeyCode changecolo;

    void Start()
    {
        matOfObject.color = Color.black;
    }

    void Update()
    {
        if(Input.GetKeyDown(changecolo))
        {
            if(matOfObject.color == Color.black)
            {
                matOfObject.color = newcolo;
            }
            else
            {
                matOfObject.color = Color.black;
            }
        }
    }
}
