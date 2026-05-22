/******************************************************************************
 * Author: Brad Dixon
 * Creation Date: 5/22/2026
 * Last Modified: 5/22/2026
 * Brief: Handles the player's controls.
 * External Resources: N/A
 * ***************************************************************************/
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    public enum GameplayStates
    {
        World,
        Dialogue,
        Rhythm
    }

    [SerializeField] private GameplayStates playerState;

    PlayerInput pInput;
    InputAction pMove, pInteract, pClick;
    InputAction note1, note2, note3, note4;

    [Tooltip("How fast the player moves.")]
    [SerializeField] private float playerSpeed;

    Rigidbody rb;

    /// <summary>
    /// Assignes components and values
    /// </summary>
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pInput = GetComponent<PlayerInput>();

        pInput.currentActionMap.Enable();
        pMove = pInput.currentActionMap.FindAction("Move");
        pInteract = pInput.currentActionMap.FindAction("Interact");
        pClick = pInput.currentActionMap.FindAction("Click");
        note1 = pInput.currentActionMap.FindAction("Note1");
        note2 = pInput.currentActionMap.FindAction("Note2");
        note3 = pInput.currentActionMap.FindAction("Note3");
        note4 = pInput.currentActionMap.FindAction("Note4");
    }

    /// <summary>
    /// Enables input actions
    /// </summary>
    private void OnEnable()
    {
        pMove.performed += PMove_performed;
        pInteract.started += PInteract_started;
        pClick.started += PClick_started;
        note1.started += Note1_started; note1.canceled += Note1_canceled;
        note2.started += Note2_started; note2.canceled += Note2_canceled;
        note3.started += Note3_started; note3.canceled += Note3_canceled;
        note4.started += Note4_started; note4.canceled += Note4_canceled;
    }

    /// <summary>
    /// Disables the input system
    /// </summary>
    private void OnDisable()
    {
        pMove.performed -= PMove_performed;
        pInteract.started -= PInteract_started;
        pClick.started -= PClick_started;
        note1.started -= Note1_started; note1.canceled -= Note1_canceled;
        note2.started -= Note2_started; note2.canceled -= Note2_canceled;
        note3.started -= Note3_started; note3.canceled -= Note3_canceled;
        note4.started -= Note4_started; note4.canceled -= Note4_canceled;
    }

    #region InputFunctions
    private void PMove_performed(InputAction.CallbackContext obj)
    {
        
    }

    private void PInteract_started(InputAction.CallbackContext obj)
    {
        
    }

    private void PClick_started(InputAction.CallbackContext obj)
    {
        
    }

    private void Note1_started(InputAction.CallbackContext obj)
    {
        
    }

    private void Note1_canceled(InputAction.CallbackContext obj)
    {
        
    }

    private void Note2_started(InputAction.CallbackContext obj)
    {
        
    }

    private void Note2_canceled(InputAction.CallbackContext obj)
    {
        
    }

    private void Note3_started(InputAction.CallbackContext obj)
    {
        
    }

    private void Note3_canceled(InputAction.CallbackContext obj)
    {
        
    }

    private void Note4_started(InputAction.CallbackContext obj)
    {
        
    }

    private void Note4_canceled(InputAction.CallbackContext obj)
    {
        
    }
    #endregion

    /// <summary>
    /// Move the player
    /// </summary>
    private void FixedUpdate()
    {
        if(playerState == GameplayStates.World)
        {
            Vector2 moveDir = pMove.ReadValue<Vector2>();
            rb.linearVelocity = new Vector3(moveDir.x, rb.linearVelocity.y, moveDir.y) * playerSpeed;
        }
    }
}
