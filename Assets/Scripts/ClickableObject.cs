using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] int destroyTime = 2;
    public ParticleSystem item_taken_particle_system;
    private Animator animator;
    private bool isAnimationPlaying;

    private void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();

        // Ensure the animator is not null
        if (animator == null)
        {
            Debug.LogError("Animator component not found on this GameObject.");
            enabled = false; // Disable the script to prevent errors
        }
    }

    private void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0) && !isAnimationPlaying)
        {
            // Raycast from the mouse position to check if it hits this object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Play the animation
                Destroy(gameObject, destroyTime);
                animator.SetBool("isTaken", true);
                isAnimationPlaying = true;
                item_taken_particle_system.Play();
            }
        }
    }

    // Called by an animation event to reset isAnimationPlaying
    public void AnimationFinished()
    {
        isAnimationPlaying = false;
    }
}
