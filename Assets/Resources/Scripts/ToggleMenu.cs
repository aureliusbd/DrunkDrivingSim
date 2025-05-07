using UnityEngine;
using UnityEngine.InputSystem;

public class MenuToggle : MonoBehaviour
{
    public Canvas menuCanvas;
    public InputActionReference toggleInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggleInput.action.performed += ToggleMenu;
    }

    public void EnableMenu()
    {
        menuCanvas.enabled = true;
    }

    public void DisableMenu()
    {
        menuCanvas.enabled = false;
    }

    public void ToggleMenu(InputAction.CallbackContext ctx)
    {
        if(menuCanvas.enabled)
        {
            DisableMenu();
        }
        else
        {
            EnableMenu();
        }
    }
}
