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
    // M�todo chamado no in�cio do jogo
    void Start()
    {
        spawnPosition = transform.position;
    }

    // Update � chamado uma vez por frame
    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    // Movimenta o tanque baseado na entrada do jogador
    void HandleMovement()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotate = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, rotate, 0);
    }

    // Atira um proj�til se o jogador pressionar espa�o
    void HandleShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        }
    }
}
