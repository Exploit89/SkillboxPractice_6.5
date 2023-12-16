using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private const float StartTime = 10;
    private const float EndTime = 0;

    [SerializeField] private InputField _timer;
    [SerializeField] private EndgameHandler _endgameHandler;

    private float _currentTime;

    public void Restart() => _currentTime = StartTime;

    private void Start() => Restart();

    private void Update() => UpdateTime();

    private void UpdateTime()
    {
        if (_currentTime >= EndTime && _endgameHandler.IsGamePlaying)
            _currentTime -= Time.deltaTime;
        else if (Mathf.Round(_currentTime) == EndTime)
            _endgameHandler.GameLose();
        UpdateTimerView();
    }

    private void UpdateTimerView()
    {
        _timer.text = Mathf.Round(_currentTime).ToString();
    }
}
