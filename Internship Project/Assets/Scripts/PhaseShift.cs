using UnityEngine;
using System.Collections;

public class PhaseShift : MonoBehaviour
{
    public float phaseDuration = 3f;
    public Material phaseMaterial;
    public Material normalMaterial;

    private Renderer playerRenderer;
    private Collider playerCollider;
    private bool isPhased = false;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        playerCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !isPhased)
        {
            StartCoroutine(ActivatePhaseShift());
        }
    }

    IEnumerator ActivatePhaseShift()
    {
        isPhased = true;

        // Apply phase material and disable collisions
        playerRenderer.material = phaseMaterial;
        playerCollider.enabled = false;

        yield return new WaitForSeconds(phaseDuration);

        // Revert to normal
        playerRenderer.material = normalMaterial;
        playerCollider.enabled = true;

        isPhased = false;
    }
}
