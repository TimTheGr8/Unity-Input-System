using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private PracticalPlayer _player;

    private GameInputs _input;

    void Start()
    {
        InitializeInputs();
    }

    void  Update()
    {
        var move = _input.Player.Movement.ReadValue<Vector2>();
        _player.Move(move);
    }


    private void InitializeInputs()
    {
        _input = new GameInputs();
        _input.Player.Enable();

        _input.Player.Fire.performed += Fire_performed;
    }

    private void Fire_performed(InputAction.CallbackContext context)
    {
        _player.Fire();
    }
}
