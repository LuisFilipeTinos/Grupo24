using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTestScreenController : MonoBehaviour
{
    [SerializeField] DialogueController dialogueController;
    [SerializeField] Dialogue dialogueTest;

    [SerializeField] GameObject btnNextSentence;
    [SerializeField] GameObject btnBackToMainMenu;

    [SerializeField] TextMeshProUGUI btnNextSentenceText;

    [SerializeField] LevelLoaderController levelLoaderController;

    async void Start()
    {
        await Awaitable.WaitForSecondsAsync(1.5f);
        dialogueController.OpenDialogueAnim();
        await Awaitable.WaitForSecondsAsync(0.4f);
        await dialogueController.NextSentence(dialogueTest);
        btnNextSentence.SetActive(true);
    }

    public async void ClickNextSentence()
    {
        btnNextSentence.SetActive(false);
        await dialogueController.NextSentence(dialogueTest);

        if (dialogueController.GetIndex() != 0)
            btnNextSentence.SetActive(true);

        if (dialogueTest.GetDialogue.Length == dialogueController.GetIndex())
        {
            btnNextSentenceText.text = "VAMOS LÁ!";
            btnBackToMainMenu.SetActive(true);
        }
        else if (dialogueController.GetIndex() == 0)
            await AdvanceToNextSceneInBuildIndex();
    }

    public async void BackToMainMenu()
    {
        await levelLoaderController.LoadLevel(Enums.Scenes.InitialScreen);
    }

    public async Task AdvanceToNextSceneInBuildIndex()
    {
        await levelLoaderController.LoadLevelWithIndex(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
