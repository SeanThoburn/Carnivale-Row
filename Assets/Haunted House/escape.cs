using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escape : MonoBehaviour
{
    public GameObject jackBox;
    public GameObject self;
    public GameObject text;
    public GameObject countdown;
    public GameObject timer;

    private void OnTriggerEnter()
    {
        jackBox.gameObject.SetActive(true);
        text.gameObject.SetActive(true);
        countdown.gameObject.SetActive(true);
        timer.gameObject.SetActive(true);
        self.gameObject.SetActive(false);
    }
}
