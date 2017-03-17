using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float Life;

    public void dealDamage(float damage)
    {
        Life -= damage;
        if (Life <= 0)
            destroyObj();
    }
    public void destroyObj()
    {
        Destroy(gameObject);
    }
}
