using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{

    public Animator AnimatorProp;

    public override void Interact()
    {
        if (AnimatorProp.GetBool("opened"))
            AnimatorProp.SetBool("opened", false);
        else
            AnimatorProp.SetBool("opened", true);
    }

    // Start is called before the first frame update
    void Start()
    {
        AnimatorProp = gameObject.GetComponent<Animator>();
    }

    
}
