﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player PlayerObj;

    void Start()
    {
        PlayerObj = new Player() { RigidBody = GetComponent<Rigidbody2D>() };
    }
}
