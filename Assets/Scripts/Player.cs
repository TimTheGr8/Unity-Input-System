using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputs _input;

    private void Start()
    {
        //Get a reference and start an instance of our Input Actions
        _input = new PlayerInputs();
        //Enable Input Action Map
        _input.Dog.Enable();
        //Register perform functions
        _input.Dog.Bark.performed += Bark_performed;
        _input.Dog.Bark.canceled += Bark_canceled;
        // Walk
        _input.Dog.Walk.performed += Walk_performed;
        // Run
        _input.Dog.Run.performed += Run_performed;
        _input.Dog.Run.canceled += Run_canceled;
        // Die
        _input.Dog.Die.performed += Die_performed;
    }

    private void Run_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Runnign done: " + context);
    }

    private void Die_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Die: " + context);
    }

    private void Run_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Running: " + context);
    }

    private void Walk_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Walking: " + context);
    }

    private void Bark_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Done Barking " + context);
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("BARK BARK" + context);
    }
}
