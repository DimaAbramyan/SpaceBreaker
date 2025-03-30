using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : Enemy
{
    [SerializeField] private EnemyTurretBullet EnBullet;
    [SerializeField] private int shoots;
    [SerializeField] Transform ShootPos;
    int changing_shoots;
    float ReloadingTimer;
    float ShootingTimer;
    Transform playerPosition;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = player.transform;
        ReloadingTimer = 1;
        changing_shoots = shoots;
        StartCoroutine(Shoot());
    }
    private void Update()
    {
        // Рассчитываем направление на игрока
        Vector3 direction = playerPosition.position - ShootPos.position;

        // Угол поворота (в радианах, переводим в градусы)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Поворачиваем объект
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
    IEnumerator Shoot()
    {
        ReloadingTimer -= Time.deltaTime / ReloadingTimer;
        while (true) {
        
            while (changing_shoots > 0)
            {
                yield return new WaitForSeconds(0.4f);
                Instantiate(EnBullet, ShootPos.position, Quaternion.Euler(0, 0, 0));
                MinusShoot();
                //Debug.Log(shoots);
            }
            changing_shoots = shoots;
            yield return new WaitForSeconds(3f);
        }
    }
    private void MinusShoot()
    {
        changing_shoots--;
        
    }
}
