using UnityEngine;

public class MainCanvas : SourceCanvas
{
    [SerializeField] UnityEngine.UI.Button _mainButton;
    [SerializeField] LoadSprites _loadSprites;

    Animator _animator;

    protected override void Start()
    {
        base.Start();

        _mainButton.onClick.AddListener(OnClickMainButton);
        _animator = _mainButton.GetComponent<Animator>();
    }

    private void OnDestroy()
    {
        _mainButton.onClick.RemoveAllListeners();
    }

    void OnClickMainButton()
    {
        _animator.SetBool("anim", true);
        _loadSprites.Load();
    }
}
