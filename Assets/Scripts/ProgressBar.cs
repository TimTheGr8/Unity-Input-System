using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private Slider _progressBar;

    private JumpingInputs _input;
    private bool _charging = false;

    // Start is called before the first frame update
    void Start()
    {
        _input = new JumpingInputs();
        _input.Player.Enable();

        _input.Player.Jump.canceled += Jump_canceled;
        _input.Player.Jump.started += Jump_started;
    }

    private void Jump_started(InputAction.CallbackContext context)
    {
        _charging = true;
        StartCoroutine(ChargeBarRoutine());
    }

    private void Jump_canceled(InputAction.CallbackContext context)
    {
        _charging = false;
    }

    IEnumerator ChargeBarRoutine()
    {
        while (_charging)
        {
            _progressBar.value += 0.5f * Time.deltaTime;
            yield return null;
        }

        while (_progressBar.value > 0 && !_charging)
        {
            _progressBar.value -= 0.5f * Time.deltaTime;
            yield return null;
        }
    }
}
