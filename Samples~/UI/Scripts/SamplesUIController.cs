using System.Collections;
using System.Collections.Generic;
using Broccollie.UI;
using UnityEngine;

public class SamplesUIController : MonoBehaviour
{
    [Header("Boards")]
    [SerializeField] private ButtonUI _buttonsButton = null;
    [SerializeField] private ButtonUI _panelsButton = null;
    [SerializeField] private PanelUI _buttonsPanel = null;
    [SerializeField] private PanelUI _panelsPanel = null;

    [Header("Scale")]
    [SerializeField] private ButtonUI _showButtonTrigger_0 = null;
    [SerializeField] private ButtonUI _showButton_0 = null;
    [SerializeField] private ButtonUI _showButtonTrigger_1 = null;
    [SerializeField] private ButtonUI _showButton_1 = null;
    [SerializeField] private ButtonUI _showButtonTrigger_2 = null;
    [SerializeField] private ButtonUI _showButton_2 = null;

    [Header("Animation")]
    [SerializeField] private ButtonUI _animationShowTrigger_0 = null;
    [SerializeField] private ButtonUI _animationShow_0 = null;
    [SerializeField] private ButtonUI _animationShowTrigger_1 = null;
    [SerializeField] private ButtonUI _animationShow_1 = null;
    [SerializeField] private ButtonUI _animationShowTrigger_2 = null;
    [SerializeField] private ButtonUI _animationShow_2 = null;


    private void Awake()
    {
        _buttonsButton.OnSelect += (sender, args) => _buttonsPanel.SetVisible(true);
        _panelsButton.OnSelect += (sender, args) => _panelsPanel.SetVisible(true);

        _showButtonTrigger_0.OnSelect += (sender, args) => _showButton_0.SetVisible(true);
        _showButtonTrigger_0.OnDefault += (sender, args) => _showButton_0.SetVisible(false);
        _showButtonTrigger_1.OnSelect += (sender, args) => _showButton_1.SetVisible(true);
        _showButtonTrigger_1.OnDefault += (sender, args) => _showButton_1.SetVisible(false);
        _showButtonTrigger_2.OnSelect += (sender, args) => _showButton_2.SetVisible(true);
        _showButtonTrigger_2.OnDefault += (sender, args) => _showButton_2.SetVisible(false);

        _animationShowTrigger_0.OnSelect += (sender, args) => _animationShow_0.SetVisible(true);
        _animationShowTrigger_0.OnDefault += (sender, args) => _animationShow_0.SetVisible(false);
        _animationShowTrigger_1.OnSelect += (sender, args) => _animationShow_1.SetVisible(true);
        _animationShowTrigger_1.OnDefault += (sender, args) => _animationShow_1.SetVisible(false);
        _animationShowTrigger_2.OnSelect += (sender, args) => _animationShow_2.SetVisible(true);
        _animationShowTrigger_2.OnDefault += (sender, args) => _animationShow_2.SetVisible(false);
    }

    private void Start()
    {
        _buttonsButton.Select();
    }
}