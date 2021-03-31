using System;
using UnityEngine;

public class McInput : MonoBehaviour
{
    public CharacterController2D controller;
    [SerializeField] private float speed = 40f;
    [SerializeField] private float horizontalMove = 0f;
    private McControls controls;

    //TODO add dash horizontal movement
    //TODO figure out how to dash/jump through tiles
    private void Awake()
    {
        controls = new McControls();
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false);
    }

    private void HandleMove(Single dir)
    {
        horizontalMove = dir * speed;
    }

    private void HandleStop()
    {
        horizontalMove = 0;
    }

    private void HandleJump()
    {
        controller.AttemptJump();
    }

    private void HandleDash()
    {
        controller.AttemptDash();
    }

    private void OnEnable()
    {
        controls.MC.Move.performed += context => HandleMove(context.ReadValue<Single>());
        controls.MC.Move.canceled += context => HandleStop();
        controls.MC.Jump.performed += context => HandleJump();
        controls.MC.Dash.performed += context => HandleDash();
        controls.MC.Enable();
    }

    private void OnDisable()
    {
        controls.MC.Disable();
    }
}
