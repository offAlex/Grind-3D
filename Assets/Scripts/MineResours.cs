using UnityEngine;

public class MineResours : MonoBehaviour
{
    private GameObject _player;
    private static bool _isMine = false;
    public static int MineHealth;

    private void Start()
    {
        _player = GameObject.Find("Player");
        MineHealth = Random.Range(2, 10);
    }

    private void Update()
    {
        
        if (MineHealth < 1)
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
        var dist = Vector3.Distance(_player.transform.position, transform.position);
        if (dist <= 2.0f && MineHealth>=1)
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
            MineHealth -= 1;
            Debug.Log(MineHealth);
        }
    }
}
