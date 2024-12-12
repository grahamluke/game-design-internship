using UnityEngine;
using System.Collections;

public class Cloak : MonoBehaviour
{
    public float cloakDuration = 5f;
    public Material invisibleMaterial;
    public Material normalMaterial;

    private Renderer playerRenderer;
    private bool isCloaked = false;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && !isCloaked)
        {
            StartCoroutine(ActivateCloak());
        }
    }

    IEnumerator ActivateCloak()
    {
        isCloaked = true;

        // Make player invisible
        playerRenderer.material = invisibleMaterial;

        yield return new WaitForSeconds(cloakDuration);

        // Revert to normal material
        playerRenderer.material = normalMaterial;
        isCloaked = false;
    }
}
