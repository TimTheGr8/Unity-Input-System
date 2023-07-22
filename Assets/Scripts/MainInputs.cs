using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainInputs : MonoBehaviour
{

    private MainPlayerInputs _inputs;


    // Start is called before the first frame update
    void Start()
    {
        _inputs = new MainPlayerInputs();

        _inputs.Player.Enable();
        _inputs.Player.DrivingState.performed += DrivingState_performed;
    }

    private void DrivingState_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Now Driving");
        _inputs.Player.Disable();
        _inputs.Driving.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        var rotation = _inputs.Player.Rotation.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotation);
        
        var move = _inputs.Driving.Drive.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 3.0f);
    }
}
