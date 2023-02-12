﻿using QuranAnalyzer.WebUI.Components;

namespace QuranAnalyzer.WebUI;

static class App
{
    public static StyleModifier FontFamily_Lateef => FontFamily("Lateef, cursive");

    public static StyleModifier ComponentBorder => Border($"1px solid {BorderColor}");

    public static string BluePrimary => "#1976d2";

    public static string BorderColor = "#dee2e6";
}

static class Extensions
{

    public static string FileAtImgFolder(string fileName) => "wwwroot/img/" + fileName;

    public static (string reading, string trMean)? GetTurkishPronunciationOfArabicWord(string arabicWord)
    {
        if (arabicWord == "ايام")
        {
            return ("eyyam", "günler");
        }
        if (arabicWord == "يومين")
        {
            return ("yevmeyn", "2 gün");
        }
        if (arabicWord == "الايام")
        {
            return ("el-eyyam", "günler");
        }
        if (arabicWord == "اياما")
        {
            return ("eyyamen", "günler");
        }
        if (arabicWord == "واياما")
        {
            return ("ve eyyamen", "günler");
        }
        if (arabicWord == "بايىم")
        {
            return ("bi-eyyam", "günler");
        }
        
        return null;
    }

    
   

    public static string AsText(this IReadOnlyList<LetterInfo> letters)
    {
        return string.Join(string.Empty, letters);
    }

    public static string GetLetterCountingScript(string chapterFilter, params string[] arabicLetters)
    {
        return chapterFilter + "~" + string.Join(string.Empty, arabicLetters);
    }

    public static string GetPageLink(string pageId) =>  $"/?{QueryKey.Page}=" + pageId;

   
    
    
    public static bool HasNoValue(this string value) => string.IsNullOrWhiteSpace(value);

    public static bool HasValue(this string value) => !string.IsNullOrWhiteSpace(value);

    public static void MainContentDivScrollChangedOverZero(this Client client, double mainDivScrollY)
    {
        client.DispatchEvent(nameof(MainContentDivScrollChangedOverZero));
    }

   

   

   

    public static void OnMainContentDivScrollChangedOverZero(this Client client, Action<double> handlerAction)
    {
        client.ListenEvent(MainContentDivScrollChangedOverZero, handlerAction);
    }

   

    public static string GetTurkishPronunciationOfArabicLetter(string arabicLetter)
    {
        switch (arabicLetter)
        {
            case ArabicLetter.Alif: return ArabicLetterTurkishPronunciation.Alif;
            case ArabicLetter.Baa: return ArabicLetterTurkishPronunciation.Baa;
            case ArabicLetter.Taa: return ArabicLetterTurkishPronunciation.Taa;
            case ArabicLetter.Thaa: return ArabicLetterTurkishPronunciation.Thaa;
            case ArabicLetter.Jiim: return ArabicLetterTurkishPronunciation.Jiim;
            case ArabicLetter.Haa: return ArabicLetterTurkishPronunciation.Haa;
            case ArabicLetter.Khaa: return ArabicLetterTurkishPronunciation.Khaa;
            case ArabicLetter.Daal: return ArabicLetterTurkishPronunciation.Daal;
            case ArabicLetter.Dhaal: return ArabicLetterTurkishPronunciation.Dhaal;
            case ArabicLetter.Raa: return ArabicLetterTurkishPronunciation.Raa;
            case ArabicLetter.Zay: return ArabicLetterTurkishPronunciation.Zay;
            case ArabicLetter.Siin: return ArabicLetterTurkishPronunciation.Siin;
            case ArabicLetter.Shiin: return ArabicLetterTurkishPronunciation.Shiin;
            case ArabicLetter.Saad: return ArabicLetterTurkishPronunciation.Saad;
            case ArabicLetter.Daad: return ArabicLetterTurkishPronunciation.Daad;
            case ArabicLetter.Taa_: return ArabicLetterTurkishPronunciation.Taa_;
            case ArabicLetter.Zaa: return ArabicLetterTurkishPronunciation.Zaa;
            case ArabicLetter.Ayn: return ArabicLetterTurkishPronunciation.Ayn;
            case ArabicLetter.Ghayn: return ArabicLetterTurkishPronunciation.Ghayn;
            case ArabicLetter.Faa: return ArabicLetterTurkishPronunciation.Faa;
            case ArabicLetter.Qaaf: return ArabicLetterTurkishPronunciation.Qaaf;
            case ArabicLetter.Kaaf: return ArabicLetterTurkishPronunciation.Kaaf;
            case ArabicLetter.Laam: return ArabicLetterTurkishPronunciation.Laam;
            case ArabicLetter.Miim: return ArabicLetterTurkishPronunciation.Miim;
            case ArabicLetter.Nun: return ArabicLetterTurkishPronunciation.Nun;
            case ArabicLetter.Haa_: return ArabicLetterTurkishPronunciation.Haa_;
            case ArabicLetter.Waaw: return ArabicLetterTurkishPronunciation.Waaw;
            case ArabicLetter.Yaa: return ArabicLetterTurkishPronunciation.Yaa;
        }
        
        return arabicLetter;
    }

   
    public static int AsNumber(this bool value) =>
        value ? 1 : 0;
}

