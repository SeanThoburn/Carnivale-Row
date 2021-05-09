using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject self;
    public float time;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time)
        {
            self.gameObject.SetActive(false);
        }
    }
}
