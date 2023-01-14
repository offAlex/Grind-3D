using UnityEngine;

public class MineResours : MonoBehaviour
{
    private GameObject _player;
    [Header("Distance")]
    [SerializeField] private float _dist;
    [Header("HP mine resource")]
    [SerializeField] private int mineHealth;

    private void Start()
    {
        _player = GameObject.Find("Player");
        mineHealth = Random.Range(2, 10);
    }

    private void Update()
    {
        _dist = Vector3.Distance(_player.transform.position, transform.position);
        IsMiner();
    }

    private void IsMiner()
    {
        if (_dist <= 2.0f && mineHealth>=1 && PlayerController.PlayerInput.Player.ActionType.WasPressedThisFrame())
        {
            Mine();
        }
    }
    
    private void Mine()
    {
        mineHealth -= 1;
        PlayerController.Resource += Random.Range(1, 4);
        Debug.Log("Mine");
        Debug.Log(mineHealth);
        if (mineHealth < 1)
        {
            Destroy(gameObject);
        }
    }
}