using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float health = 0f;

    [SerializeField] private float maxHealth = 100f;

    [SerializeField] private Slider healthSlider;


    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
    }

    // Update is called once per frame
    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }else if (health <= 0f)
        {
            health = 0f;
            healthSlider.value = health;
            Destroy(gameObject);
        }
    }
    private void OnGUI()
    {
        float t = Time.deltaTime / 1f;
        healthSlider.value = Mathf.Lerp(healthSlider.value, health, t);
    }
}
