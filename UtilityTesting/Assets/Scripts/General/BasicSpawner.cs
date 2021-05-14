﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Helper.ObjectPool;

public class BasicSpawner : MonoBehaviour
{
    [Min(0)] public float m_spawnDelay = 0;

    [Space]
    
    [BoxGroup("Pool")]
    public PoolPrefab m_poolPrefab;

    private float m_currentTime = 0;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= (m_currentTime + m_spawnDelay))
        {
            m_currentTime = Time.time + m_spawnDelay;

            ObjectPool.Instance.Create(m_poolPrefab.Prefab, transform.position, transform.rotation);
        }
    }
}
