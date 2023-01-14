using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    public static int Resource;
    public static int MaxCountResource = 40;
    public static int Coins;
    
    
    private Rigidbody _rb;
    public static PlayerInput PlayerInput;

    private void Awake()
    {
        PlayerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        PlayerInput.Enable();
    }
    
    private void OnDisable()
    {
        PlayerInput.Disable();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = PlayerInput.Player.Move.ReadValue<Vector2>();
        Move(moveDirection);

        if (PlayerInput.Player.Shoot.WasPressedThisFrame())
        {
            Shoot();
        }
        
    }

    private void Move(Vector2 direction)
    {
        Vector3 moveDirection = new Vector3(direction.x,0,direction.y);
        transform.position += moveDirection * (speed * Time.deltaTime);
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
    }
}
