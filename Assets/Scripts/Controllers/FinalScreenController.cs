using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScreenController : MonoBehaviour
{
    [SerializeField] LevelLoaderController levelLoaderController;

    public void BackToMainMenu()
    {
        levelLoaderController.LoadLevel(Enums.Scenes.InitialScreen);
    }
}
