using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public Transform sendTo;
    
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other);

        GameObject rig = other.gameObject;

        while (rig.name != "VR Rig") {
            rig = rig.transform.parent.gameObject;
        }

        Debug.Log(rig);

        rig.transform.position = sendTo.position;
    }
}
