using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public Transform spawn;
    public Transform[] platforms;

    private bool isSpawned = false;

    void Update() {
        if (!isSpawned && Vector3.Distance(transform.position, spawn.position) > 5) {
            transform.position = spawn.position;
        }

        isSpawned = true;

        Transform closest = null;

        float closestDistance = float.MaxValue;

        foreach (Transform platform in platforms) {
            float distance = Vector3.Distance(transform.position, platform.position);

            if (distance < closestDistance) {
                closest = platform;
                closestDistance = distance;
            }
        }

        if (closest != null) {
            transform.parent = closest;
        }
    }
}
