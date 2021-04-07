using System;
using UnityEngine;

public class McInput : MonoBehaviour
{
    public CharacterController2D controller;
    [SerializeField] private float speed = 40f;
    private float horizontalMove = 0f;
    private McControls controls;
    private float dashDirX = 0;
    private float dashDirY = 0;

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
        controller.AttemptDash(this.dashDirX, this.dashDirY);
    }

    // BUG: Player does not move, the last dash dir is remebered and is not equal to zero
    private void HandleDashDir(Vector2 dir)
    {
        dashDirX = dir.x;
        dashDirY = dir.y;
    }

    private void OnEnable()
    {
        controls.MC.Move.performed += context => HandleMove(context.ReadValue<Single>());
        controls.MC.Move.canceled += context => HandleStop();
        controls.MC.Jump.performed += context => HandleJump();
        controls.MC.Dash.performed += context => HandleDash();
        controls.MC.DashDirection.performed += context => HandleDashDir(context.ReadValue<Vector2>());
        controls.MC.Enable();
    }

    private void OnDisable()
    {
        controls.MC.Disable();
    }
}
