using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private InputField _timer;
    private float _startTime = 5;
    private float _currentTime;

    public float CurrentTime => _currentTime;

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        _currentTime = _startTime - Mathf.Round(Time.time);
        _timer.text = _currentTime.ToString();
    }
}
