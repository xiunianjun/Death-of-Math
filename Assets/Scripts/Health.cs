using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool isInstantDie;
    public float maxHealth = 100f;
    private float _currentHealth;

    public bool isDead { get; private set; }

    private MeshRenderer[] _meshes;

    private void Awake()
    {
        _meshes = GetComponentsInChildren<MeshRenderer>();
        _currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        _currentHealth = Mathf.Clamp(value: _currentHealth, min: 0, maxHealth);

        Debug.Log(message: "Current Health: " + _currentHealth);

        StartCoroutine(routine: OnDamage());
    }

    IEnumerator OnDamage()
    {
        foreach (MeshRenderer mesh in _meshes)
        {
            mesh.material.color = Color.red;
        }

        yield return new WaitForSeconds(0.1f);

        if (_currentHealth > 0)
        {
            foreach (MeshRenderer mesh in _meshes)
            {
                mesh.material.color = Color.white;
            }
        }
        else if (!isDead)
        {
            foreach (MeshRenderer mesh in _meshes)
            {
                mesh.material.color = Color.gray;
            }

            isDead = true;



            Destroy(gameObject);
        }
    }
}
