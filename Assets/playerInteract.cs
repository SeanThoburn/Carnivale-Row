using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{

    public float clickRange = 2f;

    void Update()
    {

        Vector3 forward = transform.TransformDirection(Vector3.forward);

        Ray ray = new Ray();
        ray.origin = transform.position;
        ray.direction = forward;

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, clickRange))
        {
            if (Input.GetMouseButton(0))
            {
                InteractiveObject interactiveObject = hit.transform.GetComponent<InteractiveObject>();

                if (interactiveObject != null)
                {
                    interactiveObject.Interact();
                }

            }
        }
    }
}
