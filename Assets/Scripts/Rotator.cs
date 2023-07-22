using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{

    private RotationInputs _inputs;

    // Start is called before the first frame update
    void Start()
    {
        _inputs = new RotationInputs();
        _inputs.Player.Enable();

    }


    // Update is called once per frame
    void Update()
    {
        var rotation = _inputs.Player.Rotation.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotation);
    }
}
