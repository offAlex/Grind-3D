using UnityEngine;

public class MineResours : MonoBehaviour
{
    private GameObject _player;
    [Header("Distance")]
    [SerializeField] private float dist;
    [Header("HP mine resource")]
    [SerializeField] private int mineHealth;

    private void Start()
    {
        _player = GameObject.Find("Player");
        mineHealth = Random.Range(2, 10);
    }

    private void Update()
    {
        dist = Vector3.Distance(_player.transform.position, transform.position);
        IsMiner();
    }

    private void IsMiner()
    {
        if (dist <= 2.0f && mineHealth>=1 && PlayerController.PlayerInput.Player.ActionType.WasPressedThisFrame()
            && PlayerController.MaxCountResource > PlayerController.Resource)
        {
            Mine();
        }

        if (PlayerController.MaxCountResource <= PlayerController.Resource)
        {
            PlayerController.Resource = PlayerController.MaxCountResource;
        }
    }
    
    private void Mine()
    {
        mineHealth -= 1;
        PlayerController.Resource += Random.Range(1, 4);
        if (mineHealth < 1)
        {
            ManagerSpawnMine.CountMine--;
            Destroy(gameObject);
        }
    }
}