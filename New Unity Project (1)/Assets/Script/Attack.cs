using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public Animator anim;


    void Update()
    {
        float dist = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        if(dist < 0.3)
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
        
    }
}
