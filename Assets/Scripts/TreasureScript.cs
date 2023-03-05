using UnityEngine;

public class TreasureScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log(other);

        if (other.gameObject.tag == "Hand") {
            Destroy(this.gameObject);
        }
    }
}
