using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 5;
    float lives;
    Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives;// - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }

    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives -= 1;
            UpdateDisplay();
        }
        else
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
