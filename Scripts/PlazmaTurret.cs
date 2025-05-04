using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlazmaTurret : Enemy
{
    [SerializeField] private EnemyTurretBullet EnBullet;
    [SerializeField] Transform ShootPos;
    float ReloadingTimer;
    Transform playerPosition;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.transform;
        ReloadingTimer = Random.Range(2f, 7f); ;
    }
    private void FixedUpdate()
    {
        // Рассчитываем направление на игрока
        ReloadingTimer -= Time.deltaTime;
        if (ReloadingTimer < 0)
        {
            Shoot();
        }
            Vector3 direction = playerPosition.position - ShootPos.position;

        // Угол поворота (в радианах, переводим в градусы)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Поворачиваем объект
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
    private void Shoot()
    {
        ReloadingTimer = Random.Range(8f, 12f);
        Instantiate(EnBullet, ShootPos.position, Quaternion.identity);
    }
   
}
