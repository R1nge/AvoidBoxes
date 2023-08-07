using UnityEngine;
using VContainer;
using VContainer.Unity;

public class PlayerSpawnerView : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private GameObject _playerInstance;
    private IObjectResolver _objectResolver;

    [Inject]
    private void Construct(IObjectResolver objectResolver) => _objectResolver = objectResolver;

    public void Spawn() => _playerInstance = _objectResolver.Instantiate(player);

    public void Destroy() => Destroy(_playerInstance);
}