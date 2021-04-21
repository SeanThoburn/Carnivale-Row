using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escape : MonoBehaviour
{
    public GameObject jackBox;
    public GameObject self;
    public GameObject text;

  private void OnTriggerEnter()
    {
        jackBox.gameObject.SetActive(true);
        text.gameObject.SetActive(true);
        self.gameObject.SetActive(false);
    }
}
