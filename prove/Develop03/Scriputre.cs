using System;
using System.Collections.Generic;

class Scripture
{

   private Reference _reference;
   private List<Word> _wordsList = new List<Word>();
   private bool _allHide;
   private string _text;
   private List<int> _index = new List<int>();
   private int _hideCount = 0;

   public Scripture(string scripture, Reference reference){
    _text = scripture; 
    _reference = reference;
   }


   //change scripture in list 
    public void ListWord()
    {
       foreach (string word in _text.Split(""))
      {
         Word words = new Word(word);
         _wordsList.Add(words);
      }

    }
  
  

   //not repeat indexes 
   public List<int> Populate(){
      for (int i = 0; i < _text.Split("").Count(); i++){
         _index.Add(i);
      }
      return _index;
   }

   //hide words
   public void hideWords(){
      Random random = new Random();
      for (int i=0; i<3; i++){
         if (_index.Count == 0){
            Populate();
         }
         int randomIndex = random.Next(_index.Count);
         int index = _index[randomIndex];
         _index.RemoveAt(randomIndex);
         _wordsList[index].Hidden();
         if (_wordsList[index].GetHidden()==true){
            _hideCount++;
         }
      }
   }
  
  //display scripture
  public void Display(){
   Console.Write($"{_reference.book()} {_reference.chapter()}:{_reference.initialVerse()}-{_reference.endVerse()} - ");
   foreach (Word element in _wordsList){
      Console.Write($"{element.GetWord()}");
   }
  }

  //to finish the program when all words are hidden
  public bool allHidden(){
   _allHide = _wordsList.Any(hideWords => hideWords.GetHidden() == false);
   return _allHide;
  }
}

