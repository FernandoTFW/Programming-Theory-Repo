using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float interactRadius = 2f;
    public string Name { get; set; } //ENCAPSULATION
    // Update is called once per frame
    void Update()
    {
        Move();
        Interact();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + transform.forward, interactRadius);
    }


    void Interact(){
        // Verificar si el jugador presiona la tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position + transform.forward, interactRadius);
            foreach (Collider collider in hitColliders)
            {
                switch (collider.tag)
                {
                    case "Door":
                        collider.gameObject.GetComponent<Door>().Interact();
                        break;
                    case "Button":
                        collider.gameObject.GetComponent<Button>().Interact();
                        break;
                }
                
            }
        }
    }


}
