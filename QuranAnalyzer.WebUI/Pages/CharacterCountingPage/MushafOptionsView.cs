﻿using QuranAnalyzer.WebUI.Components;
using ReactWithDotNet;
using static QuranAnalyzer.WebUI.PageId;

namespace QuranAnalyzer.WebUI.Pages.CharacterCountingPage;

class MushafOptionsView : ReactComponent
{
    public MushafOption Model { get; set; } = new();
    
    [ReactCustomEvent]
    public Action<MushafOption> MushafOptionChanged { get; set; }
    
    protected override Element render()
    {
        return new FlexColumn(JustifyContentCenter, Gap(20))
        {
            new SwitchWithLabel
            {
                Label = "Elif sayımları için Tanzil.net'i referans al",
                LabelMaxWidth = 250,
                Value = Model.UseElifReferencesFromTanzil,
                ValueChange = changeEvent =>
                {
                    Model.UseElifReferencesFromTanzil = Convert.ToBoolean(changeEvent.target.value);
                    FireMushafOptionChanged();
                }
            },

            new SwitchWithLabel
            {
                Label         = "7:69 ve 2:245 daki bestaten ve yebsutu kelimelerindeki sad-sin yazım farklılığında Sad harfini tercih et",
                LabelMaxWidth = 250,
                Value         = Model.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten,
                ValueChange = changeEvent =>
                {
                    Model.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten = Convert.ToBoolean(changeEvent.target.value);
                    FireMushafOptionChanged();
                }
            },


            new SwitchWithLabel
            {
                Label         = "68:1 tek nun olarak say",
                LabelMaxWidth = 250,
                Value         = Model.Chapter_68_Should_Single_Nun,
                ValueChange = changeEvent =>
                {
                    Model.Chapter_68_Should_Single_Nun = Convert.ToBoolean(changeEvent.target.value);
                    FireMushafOptionChanged();
                }
            },

            new SwitchWithLabel
            {
                Label         = "11:70 ve 30:21 surelerdeki Lam harf farklılığında Tanzil.neti tercih et",
                LabelMaxWidth = 250,
                Value         = Model.Use_Laam_SpecifiedByTanzil,
                ValueChange = changeEvent =>
                {
                    Model.Use_Laam_SpecifiedByTanzil = Convert.ToBoolean(changeEvent.target.value);
                    FireMushafOptionChanged();
                }
            },

            new a { Text("Mushaf ayarları hakkında detaylı bilgi"), Href(GetPageLink(PageIdOfMushafOptionsDetail)), MarginTop(10) }
        };
    }

    void FireMushafOptionChanged()
    {
        DispatchEvent(()=>MushafOptionChanged, Model);
    }
}