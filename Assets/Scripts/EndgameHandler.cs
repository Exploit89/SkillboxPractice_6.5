using UnityEngine;

public class EndgameHandler : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private Lock _lock;
    [SerializeField] private GameObject _endgamePanel;

    private void Update()
    {
        if (_timer.CurrentTime == 0)
        {
            _endgamePanel.SetActive(true);
        }
    }
}
