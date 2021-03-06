﻿using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2;

    private float horizontalAxis;
    private float verticalAxis;

    private Action actions;
    private void Start() {
        Textbox.Instance.Message("Hello[S:0.5] world!");

        actions += Move;
    }
    private void Update() {
        actions();
    }

    private void Move() {
        horizontalAxis = InputManager.HorizontalAxis;
        verticalAxis = InputManager.VerticalAxis;
        Vector3 moveFactor = new Vector3(horizontalAxis, verticalAxis, 0);
        Vector3 newPosition = transform.localPosition + (moveFactor * movementSpeed * Time.deltaTime);
        transform.localPosition = newPosition;
    }
}
