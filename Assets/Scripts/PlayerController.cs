using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    
    private Rigidbody _rb;
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }
    
    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        Vector2 moveDirection = _playerInput.Player.Move.ReadValue<Vector2>();
        Move(moveDirection);
        
        if (_playerInput.Player.Mine.WasPressedThisFrame())
        {
            MineResours.Mine();
        }

        if (_playerInput.Player.Shoot.WasPressedThisFrame())
        {
            Shoot();
        }


    }

    private void Move(Vector2 direction)
    {
        Vector3 moveDirection = new Vector3(direction.x,0,direction.y);
        transform.position += moveDirection * (_speed * Time.deltaTime);
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
    }
}
