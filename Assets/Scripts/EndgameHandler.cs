using UnityEngine;
using UnityEngine.UI;

public class EndgameHandler : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Lock _lock;
    [SerializeField] private GameObject _endgamePanel;
    [SerializeField] private Text _endgameText;

    private bool _isGamePlaying = true;
    private int[] _winState = new int[3] { 5, 5, 5 };

    public bool IsGamePlaying => _isGamePlaying;

    public void RestartGame()
    {
        _endgamePanel.SetActive(false);
        _lock.Restart();
        _isGamePlaying = true;
        _timer.Restart();
    }

    private void Update()
    {
        if (_isGamePlaying)
        {
            RefreshState();
        }
    }

    private void RefreshState()
    {
        if (Mathf.Round(_timer.CurrentTime) == 0)
        {
            _endgameText.text = "Вы проиграли!";
            _endgamePanel.SetActive(true);
            _isGamePlaying = false;
        }


        for (var i = 0; i < _winState.Length; i++)
        {
            if (_lock.Pins[i] == _winState[i])
            {
                if (i == _lock.Pins.Length - 1)
                {
                    _endgameText.text = "Вы победили!";
                    _endgamePanel.SetActive(true);
                    _isGamePlaying = false;
                }
                continue;
            }
            else
                break;
        }
    }
}
