# Homework 11
จงเขียนโปรแกรมเปลี่ยนตัวเลขจำนวนเต็มบวก (รวมทั้งเลขศูนย์) ให้เป็นคำอ่าน

## เงื่อนไข
ผลลัพธ์ที่ได้เป็นภาษาอังกฤษ
## ตัวอย่าง
ตัวอย่างด้านล่างนี้เป็นการทำงานทีละขั้นตอนตามลำดับ  
> `<<รอรับ input>>` เป็นการรอรับข้อมูลจาก keyboard
```
Please input number: <<รอรับ input>>
```

ทำการใส่ตัวเลข `112`

```
one hundred and twelve
```

## ตัวอย่าง อื่นๆ
```
0 = zero
15 = fifteen
153 = one hundred and fifty three
576 = five hundred and seventy-six
880 = eight hundred and eighty
905  = nine hundred and five
3234 = three thousand two hundred and thirty-four
7302 = seven thousand three hundred and two
5045 = five thousand and forty-five
10000 = ten thousand
50000 = fifty thousand
73000 = seventy-three thousand
40320 = forty thousand three hundred and twenty
64327 = sixty-four thousand three hundred and twenty-seven
98028 = ninety-eight thousand and twenty-eight
200000 = two hundred thousand
620000 = sixty-two hundred thousand
854000 = eight hundred and fifty-four thousand
456321 = four hundred and fifty-six thousand three hundred and twenty-one
876530 = eight hundred and seventy-six thousand five hundred and thirty
1234567 = one million two hundred and thirty-four thousand five hundred and sixty-seven
5800345 = five million eight hundred thousand three hundred and forty-five
15800345 = fifteen million eight hundred thousand three hundred and forty-five
```

## Interface(s)
```
public interface IHomework10
{
    string GetReadWordOfNumber(int number);
}
```
