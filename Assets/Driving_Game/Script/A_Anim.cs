using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Anim : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    public void A_ainm()
    {
        anim = GetComponent<Animator>();
        anim.Play("Redcar_1");
        anim.Play("Player_1");

    }

}
