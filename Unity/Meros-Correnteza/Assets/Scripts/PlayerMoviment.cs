using System.Threading;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    public int speed;
    private float boundX = 9.5f;
    private float boundY = 4.5f;
    private Rigidbody2D rigidBody;
    private Vector2 moveInput;
    public InputActionAsset InputActions;
    private InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    void Osable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        rigidBody.linearVelocity = moveInput * speed * Time.fixedDeltaTime;
    }
}
