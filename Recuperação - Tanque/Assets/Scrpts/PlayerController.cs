using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public int health = 100;

    private int kills = 0;
    private Vector3 spawnPosition;
    // Método chamado no início do jogo
    void Start()
    {
        spawnPosition = transform.position;
    }

    // Update é chamado uma vez por frame
    void Update()
    {
        HandleMovement();
        HandleShooting();
    }
}
