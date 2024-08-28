using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScreenController : MonoBehaviour
{
    [SerializeField] LevelLoaderController levelLoaderController;

    TouchPointsController touchPointsController;
    ArtifactPointsController artifactPointsController;
    [SerializeField] TextMeshProUGUI textTouchTotal;
    public void Start()
    {
        artifactPointsController = GameObject.FindGameObjectWithTag("ArtifactController").GetComponent<ArtifactPointsController>();
        touchPointsController = GameObject.FindGameObjectWithTag("TouchController").GetComponent<TouchPointsController>();
        textTouchTotal.text = touchPointsController.touchPoints.GetQuantityOfTouches().ToString();
    }
    public void BackToMainMenu()
    {
        Destroy(artifactPointsController.gameObject);
        Destroy(touchPointsController.gameObject);
        levelLoaderController.LoadLevel(Enums.Scenes.InitialScreen);
    }
}
