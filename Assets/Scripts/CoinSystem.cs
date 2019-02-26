﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour {

    private MSSceneControllerFree _MSC;
    private NewSpawnObject nso;
    [SerializeField] private float rotationSpeed = 100.0f;

    void Awake()
    {
        _MSC = FindObjectOfType<MSSceneControllerFree>();
        nso = FindObjectOfType<NewSpawnObject>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            Destroy(gameObject);
            _MSC.coinValue++;
            nso.currentObjects--;
        }
    }

    void Update()
    {
        gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }
}
