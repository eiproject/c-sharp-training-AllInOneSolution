using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAccessModifier
{
  internal class SplittingSentences
  {
    // internal SplittingSentences(string sentence)
    // {
    // string[] words = sentence.Split();
    // static string sentence;
    // string[] words = sentence.Split();
    //internal string this [int wordIndex]
    //{ 
    //get { return words[wordIndex]; }
    //set { words[wordIndex] = value; }
    //}
    //}
    //}
    internal string[] Words;
    internal SplittingSentences(string sentence)
    {
      Words = sentence.Split();
    }
  }
}
