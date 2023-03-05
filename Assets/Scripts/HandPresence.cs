using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour {

public InputDeviceCharacteristics controllerCharacteristics;

    // public bool showController = false;
    // public List<GameObject> controllerPrefabs;
    // public GameObject handModelPrefab;

    private InputDevice targetDevice;
    // private GameObject spawnedController;
    // private GameObject spawnedHandModel;

    void TryInitialize() {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices) {
            // Debug.Log(item.name);
            // Debug.Log(item.characteristics);
        }

        if (devices.Count > 0) {
            targetDevice = devices[0];

            // GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);

            // if (prefab) {
            //     // spawnedController = Instantiate(prefab, transform);
            // } else {
            //     Debug.LogError("Did not find corresponding controller model");

            //     // spawnedController = Instantiate(controllerPrefabs[0], transform);
            // }

            // spawnedHandModel = Instantiate(handModelPrefab, transform);
        }
    }

    void Start() {
        TryInitialize();
    }

    void Update() {
        if (!targetDevice.isValid) {
            TryInitialize();
        }

        // if (showController) {
        //     spawnedHandModel.SetActive(false);
        //     spawnedController.SetActive(true);
        // } else {
        //     spawnedHandModel.SetActive(true);
        //     spawnedController.SetActive(false);
        // }

        // if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        //     Debug.Log("Pressing Primary Button");

        // if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        //     Debug.Log("Trigger Pressed" + triggerValue);

        // if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
        //     Debug.Log("Primary Touchpad" + primary2DAxisValue);
    }
}
