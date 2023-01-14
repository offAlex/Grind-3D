using UnityEngine;

public class MineResours : MonoBehaviour
{
    private GameObject _player;
    private static bool _isMine = false;
    private float _dist;
    [SerializeField] private static int _mineHealth;

    private void Start()
    {
        _player = GameObject.Find("Player");
        _mineHealth = Random.Range(2, 10);
    }

    private void Update()
    {
        _dist = Vector3.Distance(_player.transform.position, transform.position);
        if (_mineHealth < 1)
        {
            Destroy(gameObject);
        }
        else
        {
            IsMiner();
        }
    }

    private void IsMiner()
    {
        
        if (_dist <= 2.0f && _mineHealth>=1)
        {
            _isMine = true;
        }
        else
        {
            _isMine = false;
        }
    }
    
    public static void Mine()
    {
        if (_isMine)
        {
            Debug.Log("Mine");
            _mineHealth -= 1;
            Debug.Log(_mineHealth);
        }
    }
}
