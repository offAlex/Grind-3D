using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    
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
        transform.position += moveDirection * (_speed * Time.deltaTime);
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
    }
}
