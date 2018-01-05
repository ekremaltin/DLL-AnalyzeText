# DLL-AnalyzeText

### Definition

```javascript  
  The app analyzes entered text.
  It split the entered text to words. Finds the most repeated groups of words in the text.
```

### Requirements
```javascript
  All you need to do is  add the TextAnalysis.dll file to references :)
```

### How To Run ?

```javascript
  After add TextAnalysis.dll file to references, creat a new Analysis object and call the metod you want.  
  Analysis analysis = new Analysis();
  
  analysis.mostRepetitive1(DESIREDTEXT) -- Return type list : the most repeated words list.
  
  wordList(DESIREDTEXT) -- the desired text is split
  and more...
```
And here's some code! :thumbsup:

```javascript
      Split characters
      char[] kar = { ' ', ',' , '.' , '\n' , '\t' , '"' ,
                '“' , ':', ';', '!', '\r', '\\', '\0', '?', '/',
                '*', '+', '&', '\'' , '^', '%','(', ')', '=', '’' , '‘',
                '>', '£', '#', '$', '½', '{', '[', ']', '}', '_',
                '_', '@', '€', '-', 'ß', 'æ', '|', 'é','”'}; 
```
