using States;
using UnityEngine;
using VContainer;

public class SoundManagerView : MonoBehaviour
{
    [SerializeField] private AudioSource death;
    private GameStateManager _gameStateManager;

    [Inject]
    private void Construct(GameStateManager gameStateManager)
    {
        _gameStateManager = gameStateManager;
    }

    private void Awake()
    {
        _gameStateManager.OnStateChanged += PlayDeathSound;
    }

    private void PlayDeathSound(GameStates state)
    {
        if (state == GameStates.GameOver)
        {
            death.Play(0);
        }
    }
}