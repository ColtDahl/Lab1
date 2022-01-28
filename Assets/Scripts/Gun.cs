using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform gunTransform;
    [SerializeField] private Transform shootPosition;
    [Range(0,600)]
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject[] bullets;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunTransform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed = rotationSpeed + 10;
            Fire();
        }
    }

    void Fire()
    {
        GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
    }
}
//example classes
//example mover
/*
public class Mover : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    float speed = 0.1f;
    private void Update()
    {
        var movement = direction * speed;
        this.transform.Translate(movement);
    }
}
*/