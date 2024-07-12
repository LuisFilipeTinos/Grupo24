using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] LevelLoaderController levelLoader;
    
    public async void TutorialScreen()
    {
        await levelLoader.LoadLevel(Enums.Scenes.TutorialScreen);
    }

    public async void CreditsScreen()
    {
        await levelLoader.LoadLevel(Enums.Scenes.CreditsScreen);
    }

    //public async void DialogueTestScreen()
    //{
    //    await levelLoader.LoadLevel(Enums.Scenes.SceneTest3);
    //}
}
