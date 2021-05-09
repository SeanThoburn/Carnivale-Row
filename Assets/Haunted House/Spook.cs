using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spook : MonoBehaviour
{
    public GameObject spooky;
    public GameObject self;

    private void OnTriggerEnter()
    {
        spooky.gameObject.SetActive(true);
        self.gameObject.SetActive(false);
    }
}
