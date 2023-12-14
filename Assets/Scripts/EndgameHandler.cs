using UnityEngine;
using UnityEngine.UI;

public class EndgameHandler : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Lock _lock;
    [SerializeField] private GameObject _endgamePanel;
    [SerializeField] private Text _endgameText;

    private bool _isGamePlaying = true;

    public bool IsGamePlaying => _isGamePlaying;

    public void RestartGame()
    {
        _endgamePanel.SetActive(false);
        _lock.InitLock();
        _isGamePlaying = true;
        _timer.Restart();
    }

    public void GameLose()
    {
        _endgameText.text = "Вы проиграли!";
        _endgamePanel.SetActive(true);
        _isGamePlaying = false;
    }

    public void GameWin()
    {
        _endgameText.text = "Вы победили!";
        _endgamePanel.SetActive(true);
        _isGamePlaying = false;
    }
}
