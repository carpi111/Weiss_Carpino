using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    private int currentHealth;

    public void doDamage(int val) {
        currentHealth -= val;

        if (currentHealth <= 0) {
            Destroy(gameObject);
        }
    }

}
