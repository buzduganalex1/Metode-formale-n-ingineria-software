class IntegerArray{
  var integerArray: set<int>;
  
  method addElem(x: int)
  requires integerArray != {}
  requires x > 0
  ensures integerArray != {}
  {
    var length := |integerArray|;
    
    var newArray : set<int>;
  }
  
  method delElem(x: int)
  requires integerArray != {}
  {
  }
  
}