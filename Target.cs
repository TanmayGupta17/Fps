using UnityEngine;

public class Target : MonoBehaviour
{
    //     [SerializeField] private float health;
    public float health = 50f;

    public void SubtractHealth(float Damage)
    {
        health -= Damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}