using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _angle;

    private void Update()
    {
        float yAngle = _angle * Time.deltaTime;
        transform.Rotate(0, yAngle, 0);
    }
}
