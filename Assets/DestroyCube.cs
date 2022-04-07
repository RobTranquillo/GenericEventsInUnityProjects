using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    void Start()
    {
        EventManager.current.DestroyCube += OnDestroyCube;
    }
    
    void OnDestroy()
    {
        EventManager.current.DestroyCube -= OnDestroyCube;
    }

    private void OnDestroyCube()
    {
        gameObject.SetActive(false);
        Debug.Log("Cube destroyed");
    }
}
