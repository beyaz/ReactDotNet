﻿namespace QuranAnalyzer;

public static class QuranAnalyzerMixin
{
    #region Public Methods
    public static Response<int> GetCountOfCharacter(IReadOnlyList<Verse> verseList, int arabicLetterIndex, MushafOptions option = null)
    {
        option ??= new MushafOptions();

        Response<int> calculateCount(Verse verse)
        {
            if (arabicLetterIndex == ArabicLetterIndex.Alif && option.UseElifCountsSpecifiedByRK && SpecifiedByRK.RealElifCounts.ContainsKey(verse.Id))
            {
                return SpecifiedByRK.RealElifCounts[verse.Id];
            }

            if (arabicLetterIndex == ArabicLetterIndex.Saad && option.Use_Sad_in_Surah_7_Verse_69_in_word_bestaten && verse.Id == "7:69")
            {
                return SpecifiedByRK.SS[verse.Id];
            }

            if (arabicLetterIndex == ArabicLetterIndex.Laam && option.Use_Lam_SpecifiedByRK && SpecifiedByRK.Lam.ContainsKey(verse.Id))
            {
                return SpecifiedByRK.Lam[verse.Id];
            }

            return verse.AnalyzedFullText.Count(x => x.ArabicLetterIndex == arabicLetterIndex);
        }

        return verseList.Sum(calculateCount);
    }
    #endregion
}