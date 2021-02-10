using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float max_health = 100f;
    public float curent_health = 0f;

    // Start is called before the first frame update
    void Start()
    {
        curent_health = max_health;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        curent_health -= amount;
    
        if (curent_health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
