using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAnimations : MonoBehaviour {

    public XRController controller = null;
    public Animator animator = null;

    public float frames = 4f;

    private float grip = 0f;
    private float trigger = 0f;

    void Update() {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.grip, out float gripTarget)) {
            float delta = gripTarget - grip;

            if (delta > 0f) {
                grip = Mathf.Clamp(grip + 1 / frames, 0f, gripTarget);
            } else if (delta < 0f) {
                grip = Mathf.Clamp(grip - 1 / frames, gripTarget, 1f);
            } else {
                grip = gripTarget;
            }

            animator.SetFloat("Flex", grip);
        }

        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerTarget)) {
            float delta = triggerTarget - trigger;

            if (delta > 0f) {
                trigger = Mathf.Clamp(trigger + 1 / frames, 0f, triggerTarget);
            } else if (delta < 0f) {
                trigger = Mathf.Clamp(trigger - 1 / frames, triggerTarget, 1f);
            } else {
                trigger = triggerTarget;
            }

            animator.SetFloat("Pinch", trigger);
        }
    }
}
