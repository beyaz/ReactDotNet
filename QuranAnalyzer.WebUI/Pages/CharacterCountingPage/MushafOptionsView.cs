﻿using ReactWithDotNet.PrimeReact;
using static QuranAnalyzer.WebUI.Extensions;
using static QuranAnalyzer.WebUI.PageId;

namespace QuranAnalyzer.WebUI.Pages.CharacterCountingPage;

class MushafOptionsView : ReactComponent<MushafOption>
{
    #region Public Properties
    public MushafOption MushafOption { get; set; }
    #endregion

    #region Methods
    protected override void constructor()
    {
        state = MushafOption ?? new MushafOption();
    }

    protected override Element render()
    {
        return new div
        {
            children =
            {
                new div
                {
                    style = { display = "flex", flexDirection = "row", alignItems = "center" },
                    children =
                    {
                        new InputSwitch
                        {
                            @checked = state.UseElifReferencesFromTanzil,
                            onChange = x =>
                            {
                                state.UseElifReferencesFromTanzil = x.value;
                                FireMushafOptionChanged();
                            }
                        },
                        new HSpace(15),
                        new h5 { text = "Elif sayımları için Tanzil.net'i referans al" }
                    }
                },
                new div
                {
                    style = { display = "flex", flexDirection = "row", alignItems = "center" },
                    children =
                    {
                        new InputSwitch
                        {
                            @checked = state.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten,
                            onChange = x =>
                            {
                                state.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten = x.value;
                                FireMushafOptionChanged();
                            }
                        },
                        new HSpace(15),
                        new h5 { text = "7:69 daki bestaten'i Sad olarak say" }
                    }
                },
                new div
                {
                    style = { display = "flex", flexDirection = "row", alignItems = "center" },
                    children =
                    {
                        new InputSwitch
                        {
                            @checked = state.CountHamzaAsAlif,
                            onChange = x =>
                            {
                                state.CountHamzaAsAlif = x.value;
                                FireMushafOptionChanged();
                            }
                        },
                        new HSpace(15),
                        new h5 { text = "Hemzeleri Elif(ﺍ) olarak say" }
                    }
                },
                new a { text = "Mushaf ayarları hakkında detaylı bilgi", href = GetPageLink(PageIdOfMushafOptionsDetail), }
            }
        };
    }

    void FireMushafOptionChanged()
    {
        ClientTask.DispatchEvent(ApplicationEventName.MushafOptionChanged, state);
    }
    #endregion
}