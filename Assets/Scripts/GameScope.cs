using Obstacles;
using Score;
using States;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public sealed class GameScope : LifetimeScope
{
    [SerializeField] private GameStateFactory gameStateFactory;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponent(gameStateFactory);
        builder.Register<GameStateManager>(Lifetime.Singleton);
        builder.Register<ScoreSaverService>(Lifetime.Singleton);
        builder.Register<ScoreService>(Lifetime.Singleton);
        builder.Register<ObstacleFactory>(Lifetime.Singleton);
        builder.Register<ObstacleSpawner>(Lifetime.Singleton);
        builder.RegisterEntryPoint<EntryPoint>();
    }
}