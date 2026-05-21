using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using NUnit.Framework;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private int speed; // Velocidade do player
    [SerializeField] private Vector2 boundX = new Vector2(); // Limite X
    [SerializeField] private Vector2 boundY = new Vector2(); // Limite Y
    private Rigidbody2D rigidBody;
    private Vector2 moveInput; // Input de movimento
    [SerializeField] private InputActionAsset InputActions; // Mapa de movimento do player
    private InputAction moveAction;
    private Animator playerAnim;
    private bool isPreso = false; // Verifica se o player pode se mover
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move"); // Ação de mover (Vector2)
    }
    void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Animations(); // Função de animações
        MovePlayer(); // Função de movimento
    }
    public void MovePlayer() // Movimentação do player
    {
        moveInput = moveAction.ReadValue<Vector2>(); // Pega o valor das teclas de movimento
        rigidBody.linearVelocity = moveInput * speed * Time.fixedDeltaTime; // Movimenta o player
        if (transform.position.x < boundX.x) // Trava nas bordas
        {
            transform.position = new Vector2(boundX.x, transform.position.y);
        }else if (transform.position.x > boundX.y)
        {
            transform.position = new Vector2(boundX.y, transform.position.y);
        }
        if (transform.position.y < boundY.x)
        {
            transform.position = new Vector2(transform.position.x, boundY.x);
        }else if (transform.position.y > boundY.y)
        {
            transform.position = new Vector2(transform.position.x, boundY.y);
        }
    }
    public void StopPlayer(bool debater) // imobiliza o player
    {
        if (!isPreso)
        {
            isPreso = true; // Deixa ele preso
            InputActions.FindActionMap("Player").Disable(); // Desativa o mapa de movimento
            if(debater) // Possibilidade de se debater
            {
                Debug.Log("Debativel");
            }else
            {
                StartCoroutine(Desprender()); // Corritina para se soltar
            }
        }
    }
    private IEnumerator Desprender() // Corrotina de se desprender
    {
        yield return new WaitForSeconds(3);
        if (isPreso)
        {
            isPreso = false;
            InputActions.FindActionMap("Player").Enable(); // Ativa a movimentação do player
        }
    }
    private void Animations()
    {
        playerAnim.SetBool("isStruggled", isPreso); // Variavel de preso
    }
}