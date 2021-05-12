using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countdown : MonoBehaviour
{

    public float time;
    public Text timertext;
    public GameObject fail;
    public GameObject screen;

    public void Start()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        timertext.text = time.ToString();
    }

    void Update()
    {
        if (time > 0) //when time is greater than
        {
            time -= Time.deltaTime;
        }
        if (time < 0) //when time is less than
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            fail.gameObject.SetActive(true);
            screen.gameObject.SetActive(false);
        }
    }
}
