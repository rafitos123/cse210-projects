using System;
using System.Collections.Generic;

class Reference
{
  private string _book;
  private string _chapter;
  private string _initialVerse;
  private string _endVerse;

   public Reference(string book, string chapter, string initialVerse){
     _book = book;
     _chapter = chapter;
     _initialVerse = initialVerse;
   }

   public Reference(string book, string chapter, string initialVerse, string endVerse){
     _book = book;
     _chapter = chapter;
     _initialVerse = initialVerse;
     _endVerse = endVerse;
   }

  public string book(){
    return _book;

  }

  public string chapter(){
    return _chapter;
  }
  
  public string initialVerse(){
    return _initialVerse;

  }

  public string endVerse(){
    return _endVerse;
  }

}