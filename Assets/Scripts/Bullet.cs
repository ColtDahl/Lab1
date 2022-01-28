using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform mainTransform;

    void Start()
    {
        StartCoroutine(FireRoutine());
    }

    float moveSpeed = 10;

    IEnumerator FireRoutine()
    {
        float time = 0;

        while (time<3)
        {
            
            mainTransform.position += mainTransform.forward * moveSpeed * Time.deltaTime;
            time += Time.deltaTime;
            yield return null;

        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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