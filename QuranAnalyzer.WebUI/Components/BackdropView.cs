﻿
namespace QuranAnalyzer.WebUI.Components;

class BackdropView: ReactComponent
{
    public bool IsActive { get; set; }

    protected override Element render()
    {
        return new div
        {
            className = "p-blockui p-component-overlay p-component-overlay-enter", 
            style =
            {
                When(!IsActive,DisplayNone),
                Zindex(3)
            },
            onClick = OnBackdropClicked
        };
    }

    void OnBackdropClicked(MouseEvent e)
    {
        ClientTask.DispatchEvent(ApplicationEventName.OnHamburgerMenuClosed);
    }
}