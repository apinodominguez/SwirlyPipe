﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeItem : MonoBehaviour
{
    private Transform rotater;

    private void Awake()
    {
        rotater = transform.GetChild(0);
    }

    public void Position(Pipe pipe, float curveRotation, float ringRotation)
    {
        transform.SetParent(pipe.transform, false);
        transform.localRotation = Quaternion.Euler(0f, 0f, -curveRotation);
        rotater.localPosition = new Vector3(0f, pipe.CurveRadius);
        rotater.localRotation = Quaternion.Euler(ringRotation, 0f, 0f);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
