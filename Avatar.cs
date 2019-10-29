﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public ParticleSystem shape, trail, burst;
    public float deathCountdown = -1f;
    private Player player;

    private void Awake()
    {
        player = transform.root.GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (deathCountdown < 0f)
        {
            shape.enableEmission = false;
            trail.enableEmission = false;
            burst.Emit(burst.maxParticles);
            deathCountdown = burst.startLifetime;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (deathCountdown >= 0f)
        {
            deathCountdown -= Time.deltaTime;
            if (deathCountdown <= 0f)
            {
                deathCountdown = -1f;
                shape.enableEmission = true;
                trail.enableEmission = true;
                player.Die();
            }
        }
    }

}

