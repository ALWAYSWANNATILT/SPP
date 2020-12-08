using System;
using System.Collections.Generic;

class Word
{
    private String word;
    public Word(String word)
    {
        this.word = word;
    }
    public String getWord()
    {
        return word;
    }
}


class Paragraph
{
    List<Word>words = new List<Word>();
    public void addWord(Word word)
    {
        words.Add(word);
    }
    public void printALL()
    {
        for (int i = 0; i < words.Count; i++)
            Console.WriteLine(words[i].getWord() + " ");
    }
}

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word1 = new Word("HELLO");
            Word word2 = new Word("C#");
            Word word3 = new Word("from");
            Word word4 = new Word("BSTU");



            Paragraph paragraph1 = new Paragraph();
            paragraph1.addWord(word1);
            paragraph1.addWord(word2);
            paragraph1.addWord(word3);
            paragraph1.addWord(word4);
            paragraph1.printALL();

         
        }
    }
}
