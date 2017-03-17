using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject projectile, gun;

    private GameObject projectileParent;

    private void Start()
    {
        projectileParent = GameObject.Find("Projectiles");
        if(!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile);
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

}
