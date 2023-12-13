using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private InputField _timer;
    [SerializeField] private EndgameHandler _endgameHandler;
    private float _currentTime = 60;

    public float CurrentTime => _currentTime;

    public void Restart() => _currentTime = 60;

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
    }
}
