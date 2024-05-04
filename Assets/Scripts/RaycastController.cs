using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    [SerializeField]
    private float raycastDistance = 5.0f;
    [SerializeField]
    LayerMask layerMask;

    private void Update()
    {
        //Perform a raycast
        RaycastHit hit;
        //if the raycast hits an object
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, layerMask))
        {
            //do something
            Debug.Log("Raycast hits " + hit.collider.gameObject.name);
            //if we press the mouse button to interact,
            if (Input.GetMouseButtonDown(0))
            {
                //interact with the object if it is an interactable
                if(hit.collider.gameObject.GetComponent<Interactable>() != null)
                {
                    //call the interact function of the interactable class
                    hit.collider.gameObject.GetComponent<Interactable>().Interact();
                }
            }
        }

        //visualize the raycast
        Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.red);
    }
}
