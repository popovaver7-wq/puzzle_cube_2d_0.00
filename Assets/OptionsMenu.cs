using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [Header("Panels")]
    public GameObject optionsPanel;
    public GameObject howToPlayPanel;
    public GameObject creditsPanel;

    [Header("Music")]
    public Slider musicSlider;

    private void Start()
    {
        optionsPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(false);

        if (musicSlider != null)
        {
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
            musicSlider.onValueChanged.AddListener(ChangeMusicVolume);
        }
    }

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void OpenHowToPlay()
    {
        optionsPanel.SetActive(false);
        howToPlayPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void OpenCredits()
    {
        optionsPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void BackToOptions()
    {
        optionsPanel.SetActive(true);
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void ChangeMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();

        // Музыки пока нет.
        // Когда добавишь музыку, сюда подключим AudioSource.
    }
}