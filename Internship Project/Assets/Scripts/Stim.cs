using UnityEngine;
using System.Collections;

public class Stim : MonoBehaviour
{
    public float stimDuration = 5f;
    public float speedMultiplier = 2f;
    public float regenAmount = 50f;
    public float regenInterval = 1f;

    private float originalSpeed = 5f; // Default player speed
    private float currentSpeed; // Current player speed
    private bool isStimming = false;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentSpeed = originalSpeed; // Initialize speed
    }

    void Update()
    {
        // Handle player movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0, moveVertical).normalized;
        characterController.Move(move * currentSpeed * Time.deltaTime);

        // Activate Stim
        if (Input.GetKeyDown(KeyCode.E) && !isStimming)
        {
            StartCoroutine(ActivateStim());
        }
    }

    IEnumerator ActivateStim()
    {
        isStimming = true;

        // Temporarily increase speed
        currentSpeed = originalSpeed * speedMultiplier;

        // Regenerate health over time
        float elapsedTime = 0f;
        while (elapsedTime < stimDuration)
        {
            Heal(regenAmount / (stimDuration / regenInterval));
            elapsedTime += regenInterval;
            yield return new WaitForSeconds(regenInterval);
        }

        // Revert speed
        currentSpeed = originalSpeed;
        isStimming = false;
    }

    void Heal(float amount)
    {
        // Assume a HealthSystem script is attached
        var healthSystem = GetComponent<HealthSystem>();
        if (healthSystem != null)
        {
            healthSystem.Heal(amount);
        }
    }
}
