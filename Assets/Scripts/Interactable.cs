using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ABSTRACTION
public abstract class Interactable : MonoBehaviour 
{
    protected Animator AnimatorProp;
    public abstract void Interact(); // ABSTRACTION
}
