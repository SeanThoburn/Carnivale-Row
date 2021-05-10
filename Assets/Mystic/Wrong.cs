using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrong : MonoBehaviour
{
    public GameObject failure;
public void fail()
    {
        failure.gameObject.SetActive(true);
    }
}
