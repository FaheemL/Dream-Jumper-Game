using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float offset;
    public GameObject Bullet;
    public float BulletSpeed;
    public Transform ShootPoint;
    private SpriteRenderer spriteRender;
    public Camera[] cams;
    private Camera cam;
    public BedWorldTrigger bed;
    public PlayerStats player;
    public AudioSource shootingSound;

    private void Start(){
        spriteRender = GetComponent<SpriteRenderer>();
        cam = cams[0];
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            shoot();
            shootingSound.Play();
            if (bed.World()) player.TakeEnergy(5);
        }
        if (!bed.World()) cam = cams[1];

        

    }
    void shoot()
    {
        GameObject bullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

        if (spriteRender.flipX)
        {
            // Player is facing left
            bulletRigidbody.velocity = new Vector2(-BulletSpeed, 0);
        }
        else
        {
            // Player is facing right
            bulletRigidbody.velocity = new Vector2(BulletSpeed, 0);
        }
    }
}
