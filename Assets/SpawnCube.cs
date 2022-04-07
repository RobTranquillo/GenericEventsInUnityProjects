using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    void Start()
    {
        EventManager.current.SpawnCube += OnSpawnCube;
    }

    void OnDestroy()
    {
        EventManager.current.DestroyCube -= OnSpawnCube;
        Debug.Log("OnDestroy");
    }

    private void OnSpawnCube()
    {
        gameObject.SetActive(true);
        Debug.Log("Cube gespawnt");
    }
}
