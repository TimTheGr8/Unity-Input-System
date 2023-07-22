using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jumper : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;

    private JumpingInputs _input;

    // Start is called before the first frame update
    void Start()
    {
        _input = new JumpingInputs();
        _input.Player.Enable();

        _input.Player.Jump.performed += Jump_performed;
        _input.Player.Jump.canceled += Jump_canceled;
    }

    private void Jump_canceled(InputAction.CallbackContext context)
    {
        var jumpPower = context.duration;
        if (jumpPower > 1)
            jumpPower = 0.2f;
        _rb.AddForce(Vector3.up * ((float)jumpPower * 15.0f), ForceMode.Impulse);
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        _rb.AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
    }
}
