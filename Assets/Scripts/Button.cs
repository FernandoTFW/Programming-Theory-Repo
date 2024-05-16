using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    public Animator AnimatorProp;


    // Start is called before the first frame update
    void Start()
    {
        AnimatorProp = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        AnimatorProp.SetTrigger("Use");
    }
}
