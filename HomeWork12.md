# Homework 10
จงเขียนโปรแกรมสำหรับป้อน input เป็น string 1 ชุด แล้วหาผลลัพธ์ดังนี้
1. ตัวอักษรตัวแรกที่ซ้ำกันใน string ชุดนั้น
1. ตัวอักษรตัวแรกที่<u>ไม่</u>ซ้ำกันใน string ชุดนั้น

## ตัวอย่าง
ตัวอย่างด้านล่างนี้เป็นการทำงานทีละขั้นตอนตามลำดับ  
> `<<รอรับ input>>` เป็นการรอรับข้อมูลจาก keyboard
```
Please input string: <<รอรับ input>>
```

ทำการใส่ string `AsviaHcLKEjvDJhFjhfd` แล้วกด enter จะได้ผลลัพธ์

```
First duplicate charactor is: v
First not duplicate charactor is: A
```

## ตัวอย่างอื่นๆ
Input: `ZXCVBNMASDFGHJ`  
Output: 
```
First duplicate charactor is: -
First not duplicate charactor is: Z
```
Input: `ZXCVBNZXCVBMASDFGHJMASDFGHJ`  
Output: 
```
First duplicate charactor is: Z
First not duplicate charactor is: N
```
Input: `ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ`  
Output: 
```
First duplicate charactor is: Z
First not duplicate charactor is: -
```

## Interface(s)
```
public interface IHomework12
{
    string FirstDuplicateCharactor();
    string FirstNotDuplicateCharactor();
}
```
