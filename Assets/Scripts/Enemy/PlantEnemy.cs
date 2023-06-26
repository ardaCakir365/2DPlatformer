using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{

    private float waitTime;
    public float waitTimeToAttack = 2;
    private float waited;


    Animator anim;

    public GameObject bulletPref;
    public Transform launchPoint;


    void Start()
    {
        anim = GetComponent<Animator>();
        waitTime = waitTimeToAttack;
    }

    void Update()
    {
        if (waitTime <= 0)
        {
            waitTime = waitTimeToAttack;
            anim.Play("Attack");
            Invoke("LaunchBullet", 0.3f);
        }
        else
        {
            waited -= Time.deltaTime;
        }
    }

    public void LaunchBullet()
    {
        Instantiate(bulletPref,launchPoint.position, launchPoint.rotation);
    }
}
