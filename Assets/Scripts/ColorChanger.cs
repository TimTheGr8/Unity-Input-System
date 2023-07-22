using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer _renderer;

    private ColorChange _input;

    // Start is called before the first frame update
    void Start()
    {
        SetupInputs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ColorChange()
    {
        _renderer.material.color = Random.ColorHSV();
    }


    private void SetupInputs()
    {
        _input = new ColorChange();
        _input.Player.Enable();

        _input.Player.ChangeColor.performed += ChangeColor_performed;
    }

    private void ChangeColor_performed(InputAction.CallbackContext context)
    {
        ColorChange();
    }
}
