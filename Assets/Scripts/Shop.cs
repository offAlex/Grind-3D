using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private GameObject _player;
    [Header("Distance")]
    [SerializeField] private float dist;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    
    private void Update()
    {
        dist = Vector3.Distance(_player.transform.position, transform.position);
        IsSell();
    }
    
    private void IsSell()
    {
        if (dist <= 2.0f && PlayerController.PlayerInput.Player.ActionType.WasPressedThisFrame())
        {
            Sell();
        }
    }

    private void Sell()
    {
        if (PlayerController.Resource > 0)
        {
            PlayerController.Coins += PlayerController.Resource * 2;
            PlayerController.Resource = 0;
        }
    }
}
