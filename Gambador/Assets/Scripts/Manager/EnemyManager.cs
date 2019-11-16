﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager
{
    [HideInInspector] public delegate void EnemyEventManager();
    [HideInInspector] public static event EnemyEventManager EnemyDeathEvent;
    [HideInInspector] public static event EnemyEventManager PopEvent;

    public void PopTrigger(Enemy enemy)
    {
        Debug.Log("I'm pop" + enemy.name);
        PopEvent?.Invoke();
    }

    public void EnemyDeathTrigger(Enemy enemy)
    {
        enemy.gameObject.SetActive(false);
        EnemyDeathEvent?.Invoke();
    }

}
