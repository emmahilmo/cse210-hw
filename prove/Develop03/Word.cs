using System;

public class Word {
    private string  _text;
    private bool _hidden = false;

    public Word(string text) {
        _text = text;
    }
    public void SetWord(string text) {
        _text = text;
    }
}