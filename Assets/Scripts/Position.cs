using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        float offsetX = 0;
        float offsetY = 0;
        float offsetZ = Time.deltaTime * _speed;
        
        transform.position -= new Vector3(offsetX, offsetY, offsetZ);
    }
}
