using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public GameObject exit;
    public float boxes;

    public void add()
    {
        boxes += 1;
    }
    void Update()
    {
        if (boxes == 3)
        {
            exit.gameObject.SetActive(true);
        }
    }

}
