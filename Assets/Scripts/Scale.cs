using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _scaleChange;

    private void Start()
    {
        float scaleCoefficient = 0.01f;
        float scaleSize = _speed * scaleCoefficient;
        
        _scaleChange = new Vector3(scaleSize, scaleSize, scaleSize);
    }

    private void Update()
    {
        transform.localScale += _scaleChange;
    }
}
