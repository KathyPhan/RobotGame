using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    public Material[] matOfObject;
    public Color newcolor, ogColor;
    public KeyCode changecolo;

    void Start()
    {
        for( int i = 0; i < matOfObject.Length; i++)
        {
            matOfObject[i].color = ogColor;
        }
        
    }

    void Update()
    {
        if(Input.GetKeyDown(changecolo))
        {
            for(int i = 0; i < matOfObject.Length; i++)
            {
                if(matOfObject[i].color == ogColor)
                {
                    matOfObject[i].color = newcolor;
                }
                else
                {
                    matOfObject[i].color = ogColor;
                }
            }
 
        }
    }
}
