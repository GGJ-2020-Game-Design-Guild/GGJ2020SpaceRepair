using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public Interactable interactable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interactable i = collision.GetComponent<Interactable>();
        if (i) {
            interactable = collision.GetComponent<Interactable>();
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (interactable)
        {
            if (collision == interactable.GetComponent<Collider2D>())
            {
                interactable = null;
            }
        }
    }
}
