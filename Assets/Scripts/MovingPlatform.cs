using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    public Transform pos1;
    public Transform pos2;
    public Transform platform;

    public float speed = 0.25f;

    void Update() {
        platform.position = Vector3.Lerp(pos1.position, pos2.position, Mathf.Sin(Time.time * speed) * 0.5f + 0.5f);
    }
}
