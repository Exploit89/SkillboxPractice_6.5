using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private InputField _timer;
    [SerializeField] private EndgameHandler _endgameHandler;
    private float _startTime = 60;
    private float _currentTime;

    public void Restart() => _currentTime = _startTime;

    private void Start()
    {
        Restart();
    }

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        if (_currentTime >= 0 && _endgameHandler.IsGamePlaying)
        {
            _currentTime -= Time.deltaTime;
            _timer.text = Mathf.Round(_currentTime).ToString();
        }
        else if (_currentTime == 0)
        {
            _endgameHandler.GameLose();
        }
    }
}
