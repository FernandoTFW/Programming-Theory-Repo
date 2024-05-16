using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : Interactable// INHERITANCE
{
    [SerializeField] TextMeshProUGUI nameText;
    List<string> names = new List<string> {
    "Jhon","Mario","Juan"};
    // Start is called before the first frame update
    void Start()
    {
        AnimatorProp = gameObject.GetComponent<Animator>();
    }

    public override void Interact()// POLYMORPHISM
    {
        AnimatorProp.SetTrigger("Use");
        Player p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (p != null)
        {
            p.Name = names[Random.Range(0, names.Count)]; //ENCAPSULATION
            nameText.text = p.Name;
        }

    }


}
