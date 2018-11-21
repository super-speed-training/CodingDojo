# Homework 06
ต่อจาก [Homework 05](HomeWork05.md)
นอกจากโปรแกรมจะสามารถควบคุมหลอดไฟ LED ได้แล้วลูกค้ายังต้องการให้เพิ่มความสามารถของโปรแกรมดังนี้
1. สามารถเซฟและโหลดสถานะของหลอดไฟ LED ได้
1. สามารถตั้งค่าในการแสดงผลได้

## เซฟและโหลดสถานะ
* เมื่อเปิดโปรแกรมขึ้นมา โปรแกรมจะทำการโหลดสถานะล่าสุดที่เคยเซฟไว้ขึ้นมา
* ถ้าปิดโปรแกรมโดยไม่เซฟ ระบบจะไม่ทำการเซฟสถานะล่าสุดไว้
* เมื่อต้องการเซฟสถานะล่าสุดให้พิมพ์คำว่า `save`
* Input ของโปรแกรมนี้เป็น `case sensitive`

## การตั้งค่า
* ไฟล์ที่ใช้ในการตั้งค่าต้องชื่อว่า `config.yaml`
* สัญลักษณ์ของหลอดไฟ LED `เปิด` และ `ปิด` สามารถตั้งค่าได้จากตัวแปรที่ชื่อว่า `on-symbol` และ `off-symbol`
* default `on-symbol` คือ `!`
* default `off-symbol` คือ ` `
* ระยะห่างของหลอดไฟ LED แต่ละหลอดสามารถตั้งค่าได้จากตัวแปรที่ชื่อว่า `spaces`
* defauly `spaces` คือ `1`

## ตัวอย่าง
ตัวอย่างด้านล่างนี้เป็นการทำงานทีละขั้นตอนตามลำดับ  
> `<<รอรับ input>>` เป็นการรอรับข้อมูลจาก keyboard

```
[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]
 1   2   3   4   5   6   7   8   9   A
Please choose LED to turn On/Off: <<รอรับ input>>
```

ทำการเลือกหลอดไฟ `4` แล้วกด enter

```
[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]
 1   2   3   4   5   6   7   8   9   A
Please choose LED to turn On/Off: <<รอรับ input>>
```

ทำการพิมพ์คำว่า `save` แล้วกด enter

```
Current state had been saved!
[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]
 1   2   3   4   5   6   7   8   9   A
Please choose LED to turn On/Off: <<รอรับ input>>
```

ทำการเลือกหลอดไฟ `A` แล้วกด enter

```
[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [!]
 1   2   3   4   5   6   7   8   9   A
Please choose LED to turn On/Off: <<รอรับ input>>
```

ทำการปิดโปรแกรม แล้วแก้ไขไฟล์ `config.yaml` ให้เป็น
```
on-symbol : ^
off-symbol : _
spaces : 3
```
แล้วทำการเปิดโปรแกรมขึ้นมาใหม่
```
Current state had been saved!
[_]   [_]   [_]   [^]   [_]   [_]   [_]   [_]   [_]   [_]
 1     2     3     4     5     6     7     8     9     A
Please choose LED to turn On/Off: <<รอรับ input>>
```

> Notes:  
Assume the data is input by console.

## Interface(s)
```
public interface IHomework06
{
    string DisplayLEDOnScreen(string ledNo);
    string LoadState();
    void SaveCurrentState();
    void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
}
```
