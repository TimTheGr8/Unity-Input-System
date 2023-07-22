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

        _input.Dog.Walk.performed += Walk_performed;
    }

    private void Walk_performed(InputAction.CallbackContext context)
    {
        Debug.Log(context);
    }

    private void Bark_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Done Barking");
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("BARK BARK");
    }
}
