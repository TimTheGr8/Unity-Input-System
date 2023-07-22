using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTesting : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
            Debug.Log("Space key pressed");
        if (Mouse.current.leftButton.wasPressedThisFrame)
            Debug.Log("Mouse pressed");
    }
}
