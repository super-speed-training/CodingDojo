# Homework 08
Write a program which accpets a number and print the triangle with height the number of lines specified using the character '/', '|' and '-'.

Suppose the following input is supplied to the program:
```
5
```
Then, the output should be:
```

    /|
   / |
  /  |
 /   |
/____|
```

> Notes:  
Assume the data is input by console.

## Interface(s)
```
public interface IHomework08
{
    string GetTriangleShapeAsText(int input);
}
```
