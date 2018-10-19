using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    public Transform Player;

    public float moveSpeed = 20;

    public float maxDistance = 30;

    public float rotateSpeed = 10;


    public GameObject Bullet;

    public Transform ShootPoint;

    public float restTime;

    public float rTime;


    public int health = 100;

    public GameObject Expl;

    void Start () {
        Player = GameObject.Find("Player").transform;
	}
	
	
	void Update () {

        if (Vector3.Distance(transform.position , Player.position) > maxDistance)
        {
            transform.position += (Player.position - transform.position).normalized * moveSpeed * Time.deltaTime;
        }

        //transform.LookAt(Player.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), rotateSpeed * Time.deltaTime);

        Shoot();

        if (health <= 0)
        {
            Instantiate(Expl, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        if (rTime >= 0)
        {
            rTime -= Time.deltaTime;
        }

        if (rTime <= 0)
        {
            Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
            rTime = restTime;
        }
    }

    void ApplyDamage()
    {
        health -= 10;
    }
}
