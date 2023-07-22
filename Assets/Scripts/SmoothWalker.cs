using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SmoothWalker : MonoBehaviour
{
    private SmoothWalkInputs _input;

    private void Start()
    {
        SetupInputs();
    }


    private void Update()
    {
        CalculateMovement();
    }

    private void CalculateMovement()
    {
        // poll or check input readings
        var move = _input.Player.Walk.ReadValue<Vector2>();
        // Moving in 2d space
        //transform.Translate(move * Time.deltaTime * 5);
        // Moving in 3d space
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 5.0f);
    }

    private void SetupInputs()
    {
        _input = new SmoothWalkInputs();

        _input.Player.Enable();
    }
}
