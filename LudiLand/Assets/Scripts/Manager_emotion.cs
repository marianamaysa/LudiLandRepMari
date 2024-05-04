using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class Manager_emotion : MonoBehaviour
{
    // Vari�vel animator
    public Animator animator;

    //Vari�vel para  indicar qual o valor do id
    public int id_Animation;

    //Id das anima��es;
    private int hiphop = 1;
    private int jolly = 2;
    private int silly = 3;
    private int rumba = 4;

    
    public void Start()
    {
        
    }

    public void Hiphope()
    {   
        if (id_Animation == 0)
        {
            id_Animation = hiphop;
            Debug.Log("apertado");
        }
        else if (id_Animation == hiphop)
        {
            id_Animation = 0;
            Debug.Log("desapertado");
        }

        //Muda a condi��o do animator para o valor da vari�vel id_Animation
        animator.SetInteger("idAnimation", id_Animation);
    }

    public void Joll()
    {
        if (id_Animation == 0)
        {
            id_Animation = jolly;
            Debug.Log("jolly apertado");
        }
        else if (id_Animation == jolly)
        {
            id_Animation = 0;
            Debug.Log("Jolly desapertado");
        }
        animator.SetInteger("idAnimation", id_Animation);
    }

    public void Sill()
    {
        if (id_Animation == 0)
        {
            id_Animation = silly;
        }
        else if (id_Animation == silly)
        {
            id_Animation = 0;
        }
        animator.SetInteger("idAnimation", id_Animation);
    }
    public void Rumb()
    {
        if (id_Animation == 0)
        {
            id_Animation = rumba;
        }
        else if (id_Animation == rumba)
        {
            id_Animation = 0; 
        }
        animator.SetInteger("idAnimation", id_Animation);
    }

    
}