﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject ui;
    public AudioSource audio;

    void Awake()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    // Update is called once per frame
    public void OnStart ()
    {
        Time.timeScale = 1;
        audio.Play();
        ui.SetActive(false);
    }
}
