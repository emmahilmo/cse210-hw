using System;

public class Scripture {
    Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        List<string> words =new List<string>(text.Split(' '));
        foreach (var word in words) {
            
            Word word1 = new (word);
            _words.Add(word1);
        }
    }
    public int GetWord() {
        return _words.Count();
    }
    public void HideRandomWord(int numberHide) {
        _words[numberHide].Hide();
    }
}