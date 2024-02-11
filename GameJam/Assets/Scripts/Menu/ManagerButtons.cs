using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class ManagerButtons : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField]
    private GameObject SettingsCanvas;
    [SerializeField]
    private GameObject MainCanvas;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenSettings()
    {
        MainCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void CloseSettings()
    {
        MainCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }

}
