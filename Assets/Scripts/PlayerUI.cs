using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Health playerHealth;
    public Image[] heartImages;
    int health = 0;

    void Awake()
    {
        Health health = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!playerHealth) return;

        if (health != playerHealth.healthAmount) UpdateHealth();
    }

    // This function will be used to regularly update the hearts on screen to match how much health the player has.
    void UpdateHealth()
    {
        health = playerHealth.healthAmount;

        for (int i = 0; i < health; i++)
        {
            if (i < health)
            {

            }
        }
            // For each iteration(i), if the current value of i, is less than health, 
            //set that heart to be enabled (heartImages[i].enabled = true).
            //Otherwise, set that heart to be disabled (heartImages[i].enabled = false).
                
        for (int i = 0; i < heartImages.Length; i++)
        {
            if (i < health) heartImages[i].enabled = true;
            else heartImages[i].enabled = false;
        }
    }
}
