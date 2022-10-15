using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // TODO: Save High Score

    public Text scoreText;
    public Text requirementText;
    public Text coinText;
    public Text endCoins;

    public GameObject levelCompletePanel;
    public Player _player;

    public static int coinValue;
    public static int scoreValue;
    public static int fishValue;

    public GameObject retryButton;
    public GameObject nextLevelButton;


    private void Start()
    {
        coinValue = 0;
        fishValue = 5;
        levelCompletePanel.SetActive(false);
        retryButton.SetActive(false);   
    }

    private void Update()
    {
        coinText.text = "" + coinValue;
        scoreText.text = "" + scoreValue;
        requirementText.text = "Fish To Eat: " + fishValue;
    }

    public void RetryLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelComplete()
    {
        // Play SFX
        _player.spriteRenderer.enabled = false;
        levelCompletePanel.SetActive(true);
        endCoins.text = "" + coinValue;
        Time.timeScale = 0;
    }
}
