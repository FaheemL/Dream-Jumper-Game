using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public GameObject shootPoint;
    public Vector3 shootPointOffsetLeft;
    public Vector3 shootPointOffsetRight;
    private SpriteRenderer playerSpriteRenderer;

    void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        RotateShootPoint();
    }

    private void RotateShootPoint()
    {
        if (playerSpriteRenderer.flipX)
        {
            // Player is facing left
            shootPoint.transform.localPosition = shootPointOffsetLeft;
        }
        else
        {
            // Player is facing right
            shootPoint.transform.localPosition = shootPointOffsetRight;
        }
    }
}

