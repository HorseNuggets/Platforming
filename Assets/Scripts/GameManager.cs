using UnityEngine;

public class GameManager : MonoBehaviour {

    private bool gameIsOver = false;

    public GameObject cameraObject;
    public GameObject winScreen;

    void Start() {
        StartGame();
    }

    void StartGame() {
        gameIsOver = false;
    }

    void Exit() {
        Application.Quit();
    }

    void Update() {
        GameObject[] treasures = GameObject.FindGameObjectsWithTag("Treasure");

        if (!gameIsOver && treasures.Length == 0) {
            gameIsOver = true;

            Debug.Log("You win!");

            Instantiate(winScreen, cameraObject.transform);

            Invoke("Exit", 3);
        }
    }
}
