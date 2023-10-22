using System;
using System.Collections.Generic;

class Word
{
    private string _word;
    private bool _hidden;
   public Word(string word){
    _word = word;
    _hidden = false;

   }

   //to hide using "_"
   public void Hidden(){
    _word = new string('_', _word.Length);
    _hidden = true;
   }

   public bool GetHidden(){
    return _hidden;
   }

   public string GetWord(){
    return _word;
   }

}