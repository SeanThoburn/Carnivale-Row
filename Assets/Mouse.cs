﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public void mouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
