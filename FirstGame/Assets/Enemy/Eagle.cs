using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    public float EagleSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag=="FEnemy")
        {
            Destroy(enemy.gameObject);
        }
    }




}
