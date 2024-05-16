using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable// INHERITANCE
{

    public override void Interact()// POLYMORPHISM
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
