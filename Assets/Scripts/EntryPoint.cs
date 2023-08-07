using Score;
using States;
using VContainer;
using VContainer.Unity;

public sealed class EntryPoint : IInitializable, IStartable
{
    private readonly ScoreSaverService _scoreSaverService;
    private readonly GameStateManager _gameStateManager;

    [Inject]
    public EntryPoint(
        ScoreSaverService scoreSaverService,
        GameStateManager gameStateManager
    )
    {
        _scoreSaverService = scoreSaverService;
        _gameStateManager = gameStateManager;
    }

    public void Initialize()
    {
        _scoreSaverService.LoadHighScore();
        _gameStateManager.Init();
    }

    public void Start()
    {
        _gameStateManager.ChangeState(GameStates.MainMenu);
    }
}