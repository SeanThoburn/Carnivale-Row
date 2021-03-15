using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveObject : MonoBehaviour
{
    public UnityEvent InteractEvent;

    public GameObject message;


    void Start()
    {
       message.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            message.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        message.SetActive(false);
    }

    public void Interact()
    {
        InteractEvent.Invoke();
    }

    void Awake()
    {
        if (InteractEvent == null)
        {
            InteractEvent = new UnityEvent();
        }

    }
}
