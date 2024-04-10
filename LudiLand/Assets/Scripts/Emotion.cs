using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotion : MonoBehaviour
{
    public Material yellow, blue, red;
    public int Cont = 0;
    public GameObject quadrado;
    public void OnMouseDown()
    {
        if (Cont == 0)
        {
            quadrado.gameObject.GetComponent<Renderer>().material = yellow;
            Cont = 1;
        }
        else if (Cont == 1)
        {
            quadrado.gameObject.GetComponent<Renderer>().material = red;
            Cont = 2;
        }
        else if (Cont == 2)
        {
            quadrado.gameObject.GetComponent<Renderer>().material = blue;
            Cont = 0;
        }
    }
}
