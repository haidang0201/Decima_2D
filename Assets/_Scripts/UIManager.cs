using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Ins { get; private set; }
    [SerializeField] TextMeshProUGUI scoreText;   // kéo Text UI vào đây
    int score = 0;
    private void Awake() {
        if (Ins != null && Ins != this)
        {
            Destroy(gameObject);
        }
        else Ins = this;
        
    }

   public void updateCoins()
    {
        score++;
        scoreText.text = "" + score;
    }
}
